using Leftware.Utils.TemplateUtil.Model;
using Newtonsoft.Json;
using Scriban.Runtime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Leftware.Utils.TemplateUtil
{
    public partial class FrmMain : Form, ISourceInline, ISourceFile, ISourceDatabase
    {
        private Dictionary<string, string> _result;
        private SourceProviderFactory _sourceProviderFactory;

        // ISource implementations
        public string Content => sciSource.Text;

        public string FilePath => txtSourceFile.Text;

        public DatabaseType DatabaseType => (DatabaseType)cboDbType.SelectedIndex;

        public string ConnectionString => txtConnectionString.Text;

        public string Query => sciQuery.Text;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEnvironmentValues();
        }

        private void btnSaveSource_Click(object sender, EventArgs e)
        {
            var name = Prompt.GetText("Source name", "Leftware Template");
            if (name == null) return;

            TemplateSourceModel source = GetTemplateSourceModel();

            var json = JsonConvert.SerializeObject(source);
            var sourcesFolder = Utils.GetAppFolder(AppFolder.Sources);
            var file = Path.Combine(sourcesFolder, name + ".json");
            File.WriteAllText(file, json);
        }

        private void btnLoadSource_Click(object sender, EventArgs e)
        {
            var sourcesFolder = Utils.GetAppFolder(AppFolder.Sources);
            var files = Directory.GetFiles(sourcesFolder, "*.json").Select(r => Path.GetFileNameWithoutExtension(r)).ToList();
            if (files.Count == 0)
            {
                MessageBox.Show("No sources saved yet");
                return;
            }

            var result = Prompt.GetItemFromList("Select source to load", "Leftware Template Util", files);
            if (result == null) return;

            var path = Path.Combine(sourcesFolder, result + ".json");
            var json = File.ReadAllText(path);
            var src = JsonConvert.DeserializeObject<TemplateSourceModel>(json);

            LoadTemplateSourceModel(src);
        }

        private void btnOpenSourceFolder_Click(object sender, EventArgs e)
        {
            var sourcesFolder = Utils.GetAppFolder(AppFolder.Sources);
            Process.Start(sourcesFolder);
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            var fileName = Prompt.GetText("Template name", "Template Util");
            if (fileName == null) return;

            var templateFolder = Utils.GetAppFolder(AppFolder.Templates);
            var file = Path.Combine(templateFolder, fileName + ".txt");

            File.WriteAllText(file, sciTemplate.Text);
            LoadTemplates();
        }

        private void btnOpenTemplateFolder_Click(object sender, EventArgs e)
        {
            var templateFolder = Utils.GetAppFolder(AppFolder.Templates);
            Process.Start(templateFolder);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (cboSourceType.SelectedIndex == -1)
            {
                MessageBox.Show("Select the type of the source");
                return;
            }
            if (cboSourceFormat.SelectedIndex == -1 && cboSourceType.SelectedIndex != 2)
            {
                MessageBox.Show("Select the format of the source");
                return;
            }

            Execute();
        }

        private void btnExportAs_Click(object sender, EventArgs e)
        {
            if (cboExportAs.SelectedIndex == -1) return;
            if (_result == null) return;

            var exportMode = (ExportMode)cboExportAs.SelectedIndex;
            switch (exportMode)
            {
                case ExportMode.ClipboardSeparatedText:
                    var txt = string.Join(Environment.NewLine, _result.Select(itm => itm.Key + "\t" + itm.Value));
                    Clipboard.SetText(txt);
                    break;

                case ExportMode.FileJsonArray:
                    var sfd = new SaveFileDialog();
                    if (sfd.ShowDialog() != DialogResult.OK) return;
                    var file = sfd.FileName;
                    var json = JsonConvert.SerializeObject(_result);
                    File.WriteAllText(file, json);
                    break;

                case ExportMode.FolderTextFiles:
                    var fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() != DialogResult.OK) return;
                    var folder = fbd.SelectedPath;
                    // todo: dialog to ask user to select extension for files
                    foreach (var itm in _result)
                    {
                        var rawFileName = itm.Key + ".txt";
                        var fileName = Path.Combine(folder, rawFileName);
                        File.WriteAllText(fileName, itm.Value);
                    }
                    break;
            }
        }

        private void cboSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpSourceInline.Visible = cboSourceType.SelectedIndex == 0;
            grpSourceFile.Visible = cboSourceType.SelectedIndex == 1;
            grpSourceDatabase.Visible = cboSourceType.SelectedIndex == 2;

            cboSourceFormat.Enabled = cboSourceType.SelectedIndex != 2;

            if (cboSourceType.SelectedIndex == 2)
            {
                cboSourceFormat.SelectedIndex = -1;
            }
        }

        private void cboTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTemplates.SelectedIndex == -1)
            {
                sciTemplate.Text = "";
                return;
            }

            var templateFolder = Utils.GetAppFolder(AppFolder.Templates);
            var file = Path.Combine(templateFolder, cboTemplates.SelectedValue.ToString() + ".txt");
            sciTemplate.Text = File.ReadAllText(file);
        }

        private void lviResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviResults.SelectedItems.Count == 0) return;

            var key = lviResults.SelectedItems[0].Text;
            txtCurrentResult.Text = _result[key];
        }

        private void Initialize()
        {
            Icon = Utils.GetIcon();

            _sourceProviderFactory = new SourceProviderFactory();
            pnlSourceType.Controls.Add(grpSourceInline);
            pnlSourceType.Controls.Add(grpSourceFile);
            pnlSourceType.Controls.Add(grpSourceDatabase);
            grpSourceInline.Dock = DockStyle.Fill;
            grpSourceFile.Dock = DockStyle.Fill;
            grpSourceDatabase.Dock = DockStyle.Fill;

            cboSourceType.SelectedIndex = 0;
            cboSourceFormat.SelectedIndex = 0;

            LoadTemplates();
            LoadEnvironment();
        }

        private void LoadTemplates()
        {
            var templateFolder = Utils.GetAppFolder(AppFolder.Templates);
            var templateList = Directory.GetFiles(templateFolder, "*.txt").Select(Path.GetFileNameWithoutExtension).ToList();
            cboTemplates.DataSource = new BindingSource(templateList, null);
            cboTemplates.SelectedIndex = -1;
        }

        private void Execute()
        {
            try
            {
                var templateContent = sciTemplate.Text;
                var template = Scriban.Template.Parse(templateContent);

                var scriptObject = new ScriptObject();
                var context = new Scriban.TemplateContext { MemberRenamer = member => member.Name };
                context.PushGlobal(scriptObject);

                var list = GetSourceList();
                _result = new Dictionary<string, string>();

                var key = 0;
                foreach (var itm in list)
                {
                    scriptObject.Import(itm);
                    scriptObject["__idx__"] = key;
                    var output = template.Render(context);
                    string outputKey = key.ToString();
                    if (output.StartsWith("@@output "))
                    {
                        outputKey = Regex.Match(output, "@@output (.+)").Groups[1].Value;
                        output = Utils.RemoveFirstLines(output, 1);
                    }
                    _result[outputKey] = output;
                    key++;
                }

                ShowResult();
            }
            catch (Exception ex)
            {
                var str = ex.Message + Environment.NewLine + ex.StackTrace;
                MessageBox.Show(str);
            }
        }

        private IEnumerable<object> GetSourceList()
        {
            var sourceType = (SourceType)Enum.Parse(typeof(SourceType), cboSourceType.SelectedItem.ToString());
            var sourceFormat = sourceType == SourceType.Database ?
                SourceFormat.DataTable :
                (SourceFormat)Enum.Parse(typeof(SourceFormat), cboSourceFormat.SelectedIndex.ToString());

            var sourceProvider = _sourceProviderFactory.GetSourceProvider(sourceFormat);
            var source = sourceProvider.GetSource(sourceType, this);
            return source;
        }

        private void ShowResult()
        {
            AddColumns();
            lviResults.Items.Clear();
            foreach (var itm in _result)
            {
                var lvi = new ListViewItem(itm.Key);
                lvi.SubItems.Add(itm.Value);

                lviResults.Items.Add(lvi);
            }
        }

        private void AddColumns()
        {
            if (lviResults.Columns.Count > 0) return;

            lviResults.Columns.Add("Key");
            var col = lviResults.Columns.Add("Value");
            col.Width = 300;
        }

        private TemplateSourceModel GetTemplateSourceModel()
        {
            var sourceType = (SourceType)Enum.Parse(typeof(SourceType), cboSourceType.SelectedItem.ToString());
            var sourceFormat = sourceType == SourceType.Database ?
                SourceFormat.DataTable :
                (SourceFormat)Enum.Parse(typeof(SourceFormat), cboSourceFormat.SelectedIndex.ToString());

            var source = new TemplateSourceModel
            {
                SourceType = sourceType,
                SourceFormat = sourceFormat
            };
            switch (sourceType)
            {
                case SourceType.Inline:
                    source.Content = sciSource.Text;
                    break;

                case SourceType.File:
                    source.FilePath = txtSourceFile.Text;
                    break;

                case SourceType.Database:
                    source.DatabaseType = (DatabaseType)cboDbType.SelectedIndex;
                    source.ConnectionString = txtConnectionString.Text;
                    source.Query = sciQuery.Text;
                    break;
            }

            return source;
        }

        private EnvironmentModel GetModel()
        {
            var result = new EnvironmentModel();

            var exportMode = (ExportMode)cboExportAs.SelectedIndex;
            var selectedTab = (SelectableTab)tbc.SelectedIndex;
            TemplateSourceModel templateModel = GetTemplateSourceModel();
            result.TemplateModel = templateModel;
            result.TemplateContent = sciTemplate.Text;
            result.ResultExportAs = exportMode;
            result.CurrentTab = selectedTab;
            return result;
        }

        private void SaveEnvironmentValues()
        {
            var model = GetModel();
            var json = JsonConvert.SerializeObject(model);
            var environmentFolder = Utils.GetAppFolder(AppFolder.Environment);
            var environmentFile = Path.Combine(environmentFolder, "environment.json");
            File.WriteAllText(environmentFile, json);
        }

        private void LoadEnvironment()
        {
            var environmentFolder = Utils.GetAppFolder(AppFolder.Environment);
            var environmentFile = Path.Combine(environmentFolder, "environment.json");
            if (!File.Exists(environmentFile)) return;

            var json = File.ReadAllText(environmentFile);
            var model = JsonConvert.DeserializeObject<EnvironmentModel>(json);
            LoadTemplateSourceModel(model.TemplateModel);
            sciTemplate.Text = model.TemplateContent;
            cboExportAs.SelectedIndex = (int)model.ResultExportAs;
            tbc.SelectedIndex = (int)model.CurrentTab;
        }

        private void LoadTemplateSourceModel(TemplateSourceModel src)
        {
            cboSourceType.SelectedItem = src.SourceType.ToString();
            cboSourceFormat.SelectedIndex = src.SourceType == SourceType.Database ?
                -1 :
                (int)src.SourceFormat;
            sciSource.Text = src.Content;
            txtSourceFile.Text = src.FilePath;
            cboDbType.SelectedIndex = (int)src.DatabaseType;
            txtConnectionString.Text = src.ConnectionString;
            sciQuery.Text = src.Query;
        }
    }
}