namespace Leftware.Utils.TemplateUtil
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExecute = new System.Windows.Forms.Button();
            this.cboSourceType = new System.Windows.Forms.ComboBox();
            this.lblSourceType = new System.Windows.Forms.Label();
            this.cboSourceFormat = new System.Windows.Forms.ComboBox();
            this.lblSourceFormat = new System.Windows.Forms.Label();
            this.grpSourceInline = new System.Windows.Forms.GroupBox();
            this.sciSource = new ScintillaNET.Scintilla();
            this.grpSourceFile = new System.Windows.Forms.GroupBox();
            this.btnFileLoad = new System.Windows.Forms.Button();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.grpSourceDatabase = new System.Windows.Forms.GroupBox();
            this.sciQuery = new ScintillaNET.Scintilla();
            this.cboDbType = new System.Windows.Forms.ComboBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblDbType = new System.Windows.Forms.Label();
            this.lblQuery = new System.Windows.Forms.Label();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpSource = new System.Windows.Forms.TabPage();
            this.btnOpenSourceFolder = new System.Windows.Forms.Button();
            this.btnSaveSource = new System.Windows.Forms.Button();
            this.btnLoadSource = new System.Windows.Forms.Button();
            this.pnlSourceType = new System.Windows.Forms.Panel();
            this.tbpTemplate = new System.Windows.Forms.TabPage();
            this.btnOpenTemplateFolder = new System.Windows.Forms.Button();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.cboTemplates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sciTemplate = new ScintillaNET.Scintilla();
            this.tbpResults = new System.Windows.Forms.TabPage();
            this.btnExportAs = new System.Windows.Forms.Button();
            this.cboExportAs = new System.Windows.Forms.ComboBox();
            this.lblExportAs = new System.Windows.Forms.Label();
            this.lviResults = new System.Windows.Forms.ListView();
            this.txtCurrentResult = new System.Windows.Forms.TextBox();
            this.grpSourceInline.SuspendLayout();
            this.grpSourceFile.SuspendLayout();
            this.grpSourceDatabase.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tbpSource.SuspendLayout();
            this.tbpTemplate.SuspendLayout();
            this.tbpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(643, 510);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cboSourceType
            // 
            this.cboSourceType.FormattingEnabled = true;
            this.cboSourceType.Items.AddRange(new object[] {
            "Inline",
            "File",
            "Database"});
            this.cboSourceType.Location = new System.Drawing.Point(47, 6);
            this.cboSourceType.Name = "cboSourceType";
            this.cboSourceType.Size = new System.Drawing.Size(121, 21);
            this.cboSourceType.TabIndex = 1;
            this.cboSourceType.SelectedIndexChanged += new System.EventHandler(this.cboSourceType_SelectedIndexChanged);
            // 
            // lblSourceType
            // 
            this.lblSourceType.AutoSize = true;
            this.lblSourceType.Location = new System.Drawing.Point(10, 6);
            this.lblSourceType.Name = "lblSourceType";
            this.lblSourceType.Size = new System.Drawing.Size(31, 13);
            this.lblSourceType.TabIndex = 0;
            this.lblSourceType.Text = "Type";
            // 
            // cboSourceFormat
            // 
            this.cboSourceFormat.FormattingEnabled = true;
            this.cboSourceFormat.Items.AddRange(new object[] {
            "Json array",
            "Json object",
            "CSV"});
            this.cboSourceFormat.Location = new System.Drawing.Point(250, 6);
            this.cboSourceFormat.Name = "cboSourceFormat";
            this.cboSourceFormat.Size = new System.Drawing.Size(121, 21);
            this.cboSourceFormat.TabIndex = 3;
            // 
            // lblSourceFormat
            // 
            this.lblSourceFormat.AutoSize = true;
            this.lblSourceFormat.Location = new System.Drawing.Point(198, 6);
            this.lblSourceFormat.Name = "lblSourceFormat";
            this.lblSourceFormat.Size = new System.Drawing.Size(39, 13);
            this.lblSourceFormat.TabIndex = 2;
            this.lblSourceFormat.Text = "Format";
            // 
            // grpSourceInline
            // 
            this.grpSourceInline.Controls.Add(this.sciSource);
            this.grpSourceInline.Location = new System.Drawing.Point(288, 33);
            this.grpSourceInline.Name = "grpSourceInline";
            this.grpSourceInline.Size = new System.Drawing.Size(404, 144);
            this.grpSourceInline.TabIndex = 8;
            this.grpSourceInline.TabStop = false;
            this.grpSourceInline.Text = "Inline source";
            this.grpSourceInline.Visible = false;
            // 
            // sciSource
            // 
            this.sciSource.AutoCMaxHeight = 9;
            this.sciSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sciSource.HScrollBar = false;
            this.sciSource.Location = new System.Drawing.Point(3, 16);
            this.sciSource.Name = "sciSource";
            this.sciSource.Size = new System.Drawing.Size(398, 125);
            this.sciSource.TabIndex = 0;
            // 
            // grpSourceFile
            // 
            this.grpSourceFile.Controls.Add(this.btnFileLoad);
            this.grpSourceFile.Controls.Add(this.txtSourceFile);
            this.grpSourceFile.Controls.Add(this.lblSourceFile);
            this.grpSourceFile.Location = new System.Drawing.Point(288, 183);
            this.grpSourceFile.Name = "grpSourceFile";
            this.grpSourceFile.Size = new System.Drawing.Size(404, 83);
            this.grpSourceFile.TabIndex = 9;
            this.grpSourceFile.TabStop = false;
            this.grpSourceFile.Text = "Source file";
            this.grpSourceFile.Visible = false;
            // 
            // btnFileLoad
            // 
            this.btnFileLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileLoad.Location = new System.Drawing.Point(319, 22);
            this.btnFileLoad.Name = "btnFileLoad";
            this.btnFileLoad.Size = new System.Drawing.Size(75, 23);
            this.btnFileLoad.TabIndex = 2;
            this.btnFileLoad.Text = "Load";
            this.btnFileLoad.UseVisualStyleBackColor = true;
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFile.Location = new System.Drawing.Point(64, 22);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(249, 20);
            this.txtSourceFile.TabIndex = 1;
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(13, 22);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(29, 13);
            this.lblSourceFile.TabIndex = 0;
            this.lblSourceFile.Text = "Path";
            // 
            // grpSourceDatabase
            // 
            this.grpSourceDatabase.Controls.Add(this.sciQuery);
            this.grpSourceDatabase.Controls.Add(this.cboDbType);
            this.grpSourceDatabase.Controls.Add(this.txtConnectionString);
            this.grpSourceDatabase.Controls.Add(this.lblDbType);
            this.grpSourceDatabase.Controls.Add(this.lblQuery);
            this.grpSourceDatabase.Controls.Add(this.lblConnectionString);
            this.grpSourceDatabase.Location = new System.Drawing.Point(288, 272);
            this.grpSourceDatabase.Name = "grpSourceDatabase";
            this.grpSourceDatabase.Size = new System.Drawing.Size(404, 171);
            this.grpSourceDatabase.TabIndex = 10;
            this.grpSourceDatabase.TabStop = false;
            this.grpSourceDatabase.Text = "Source database";
            this.grpSourceDatabase.Visible = false;
            // 
            // sciQuery
            // 
            this.sciQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sciQuery.AutoCMaxHeight = 9;
            this.sciQuery.HScrollBar = false;
            this.sciQuery.Lexer = ScintillaNET.Lexer.Sql;
            this.sciQuery.Location = new System.Drawing.Point(16, 91);
            this.sciQuery.Name = "sciQuery";
            this.sciQuery.Size = new System.Drawing.Size(378, 63);
            this.sciQuery.TabIndex = 5;
            // 
            // cboDbType
            // 
            this.cboDbType.FormattingEnabled = true;
            this.cboDbType.Items.AddRange(new object[] {
            "Sql server",
            "Sqlite"});
            this.cboDbType.Location = new System.Drawing.Point(112, 50);
            this.cboDbType.Name = "cboDbType";
            this.cboDbType.Size = new System.Drawing.Size(159, 21);
            this.cboDbType.TabIndex = 3;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionString.Location = new System.Drawing.Point(112, 20);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(282, 20);
            this.txtConnectionString.TabIndex = 1;
            // 
            // lblDbType
            // 
            this.lblDbType.AutoSize = true;
            this.lblDbType.Location = new System.Drawing.Point(61, 50);
            this.lblDbType.Name = "lblDbType";
            this.lblDbType.Size = new System.Drawing.Size(44, 13);
            this.lblDbType.TabIndex = 2;
            this.lblDbType.Text = "Db type";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(16, 75);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(35, 13);
            this.lblQuery.TabIndex = 4;
            this.lblQuery.Text = "Query";
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(16, 20);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(89, 13);
            this.lblConnectionString.TabIndex = 0;
            this.lblConnectionString.Text = "Connection string";
            // 
            // tbc
            // 
            this.tbc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc.Controls.Add(this.tbpSource);
            this.tbc.Controls.Add(this.tbpTemplate);
            this.tbc.Controls.Add(this.tbpResults);
            this.tbc.Location = new System.Drawing.Point(12, 9);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(706, 495);
            this.tbc.TabIndex = 0;
            // 
            // tbpSource
            // 
            this.tbpSource.Controls.Add(this.btnOpenSourceFolder);
            this.tbpSource.Controls.Add(this.btnSaveSource);
            this.tbpSource.Controls.Add(this.btnLoadSource);
            this.tbpSource.Controls.Add(this.cboSourceType);
            this.tbpSource.Controls.Add(this.grpSourceDatabase);
            this.tbpSource.Controls.Add(this.cboSourceFormat);
            this.tbpSource.Controls.Add(this.grpSourceFile);
            this.tbpSource.Controls.Add(this.lblSourceType);
            this.tbpSource.Controls.Add(this.lblSourceFormat);
            this.tbpSource.Controls.Add(this.grpSourceInline);
            this.tbpSource.Controls.Add(this.pnlSourceType);
            this.tbpSource.Location = new System.Drawing.Point(4, 22);
            this.tbpSource.Name = "tbpSource";
            this.tbpSource.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSource.Size = new System.Drawing.Size(698, 469);
            this.tbpSource.TabIndex = 0;
            this.tbpSource.Text = "Source";
            this.tbpSource.UseVisualStyleBackColor = true;
            // 
            // btnOpenSourceFolder
            // 
            this.btnOpenSourceFolder.Location = new System.Drawing.Point(614, 6);
            this.btnOpenSourceFolder.Name = "btnOpenSourceFolder";
            this.btnOpenSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSourceFolder.TabIndex = 6;
            this.btnOpenSourceFolder.Text = "Open folder";
            this.btnOpenSourceFolder.UseVisualStyleBackColor = true;
            this.btnOpenSourceFolder.Click += new System.EventHandler(this.btnOpenSourceFolder_Click);
            // 
            // btnSaveSource
            // 
            this.btnSaveSource.Location = new System.Drawing.Point(534, 6);
            this.btnSaveSource.Name = "btnSaveSource";
            this.btnSaveSource.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSource.TabIndex = 5;
            this.btnSaveSource.Text = "Save";
            this.btnSaveSource.UseVisualStyleBackColor = true;
            this.btnSaveSource.Click += new System.EventHandler(this.btnSaveSource_Click);
            // 
            // btnLoadSource
            // 
            this.btnLoadSource.Location = new System.Drawing.Point(454, 6);
            this.btnLoadSource.Name = "btnLoadSource";
            this.btnLoadSource.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSource.TabIndex = 4;
            this.btnLoadSource.Text = "Load";
            this.btnLoadSource.UseVisualStyleBackColor = true;
            this.btnLoadSource.Click += new System.EventHandler(this.btnLoadSource_Click);
            // 
            // pnlSourceType
            // 
            this.pnlSourceType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSourceType.Location = new System.Drawing.Point(13, 33);
            this.pnlSourceType.Name = "pnlSourceType";
            this.pnlSourceType.Size = new System.Drawing.Size(679, 430);
            this.pnlSourceType.TabIndex = 7;
            // 
            // tbpTemplate
            // 
            this.tbpTemplate.Controls.Add(this.btnOpenTemplateFolder);
            this.tbpTemplate.Controls.Add(this.btnAddTemplate);
            this.tbpTemplate.Controls.Add(this.cboTemplates);
            this.tbpTemplate.Controls.Add(this.label1);
            this.tbpTemplate.Controls.Add(this.sciTemplate);
            this.tbpTemplate.Location = new System.Drawing.Point(4, 22);
            this.tbpTemplate.Name = "tbpTemplate";
            this.tbpTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTemplate.Size = new System.Drawing.Size(698, 469);
            this.tbpTemplate.TabIndex = 1;
            this.tbpTemplate.Text = "Template";
            this.tbpTemplate.UseVisualStyleBackColor = true;
            // 
            // btnOpenTemplateFolder
            // 
            this.btnOpenTemplateFolder.Location = new System.Drawing.Point(617, 6);
            this.btnOpenTemplateFolder.Name = "btnOpenTemplateFolder";
            this.btnOpenTemplateFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenTemplateFolder.TabIndex = 3;
            this.btnOpenTemplateFolder.Text = "Open templates folder";
            this.btnOpenTemplateFolder.UseVisualStyleBackColor = true;
            this.btnOpenTemplateFolder.Click += new System.EventHandler(this.btnOpenTemplateFolder_Click);
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Location = new System.Drawing.Point(536, 6);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnAddTemplate.TabIndex = 2;
            this.btnAddTemplate.Text = "Add current";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // cboTemplates
            // 
            this.cboTemplates.FormattingEnabled = true;
            this.cboTemplates.Location = new System.Drawing.Point(330, 7);
            this.cboTemplates.Name = "cboTemplates";
            this.cboTemplates.Size = new System.Drawing.Size(200, 21);
            this.cboTemplates.TabIndex = 1;
            this.cboTemplates.SelectedIndexChanged += new System.EventHandler(this.cboTemplates_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a preset template";
            // 
            // sciTemplate
            // 
            this.sciTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sciTemplate.AutoCMaxHeight = 9;
            this.sciTemplate.HScrollBar = false;
            this.sciTemplate.Location = new System.Drawing.Point(6, 40);
            this.sciTemplate.Name = "sciTemplate";
            this.sciTemplate.Size = new System.Drawing.Size(686, 391);
            this.sciTemplate.TabIndex = 4;
            // 
            // tbpResults
            // 
            this.tbpResults.Controls.Add(this.btnExportAs);
            this.tbpResults.Controls.Add(this.cboExportAs);
            this.tbpResults.Controls.Add(this.lblExportAs);
            this.tbpResults.Controls.Add(this.lviResults);
            this.tbpResults.Controls.Add(this.txtCurrentResult);
            this.tbpResults.Location = new System.Drawing.Point(4, 22);
            this.tbpResults.Name = "tbpResults";
            this.tbpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResults.Size = new System.Drawing.Size(698, 469);
            this.tbpResults.TabIndex = 2;
            this.tbpResults.Text = "Results";
            this.tbpResults.UseVisualStyleBackColor = true;
            // 
            // btnExportAs
            // 
            this.btnExportAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportAs.Location = new System.Drawing.Point(255, 440);
            this.btnExportAs.Name = "btnExportAs";
            this.btnExportAs.Size = new System.Drawing.Size(75, 23);
            this.btnExportAs.TabIndex = 4;
            this.btnExportAs.Text = "Export";
            this.btnExportAs.UseVisualStyleBackColor = true;
            this.btnExportAs.Click += new System.EventHandler(this.btnExportAs_Click);
            // 
            // cboExportAs
            // 
            this.cboExportAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboExportAs.FormattingEnabled = true;
            this.cboExportAs.Items.AddRange(new object[] {
            "Clipboard text separated by newlines",
            "Json array file",
            "Text files folder"});
            this.cboExportAs.Location = new System.Drawing.Point(64, 440);
            this.cboExportAs.Name = "cboExportAs";
            this.cboExportAs.Size = new System.Drawing.Size(185, 21);
            this.cboExportAs.TabIndex = 3;
            // 
            // lblExportAs
            // 
            this.lblExportAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExportAs.AutoSize = true;
            this.lblExportAs.Location = new System.Drawing.Point(7, 440);
            this.lblExportAs.Name = "lblExportAs";
            this.lblExportAs.Size = new System.Drawing.Size(51, 13);
            this.lblExportAs.TabIndex = 2;
            this.lblExportAs.Text = "Export as";
            // 
            // lviResults
            // 
            this.lviResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lviResults.FullRowSelect = true;
            this.lviResults.GridLines = true;
            this.lviResults.HideSelection = false;
            this.lviResults.Location = new System.Drawing.Point(6, 6);
            this.lviResults.MultiSelect = false;
            this.lviResults.Name = "lviResults";
            this.lviResults.Size = new System.Drawing.Size(216, 397);
            this.lviResults.TabIndex = 0;
            this.lviResults.UseCompatibleStateImageBehavior = false;
            this.lviResults.View = System.Windows.Forms.View.Details;
            this.lviResults.SelectedIndexChanged += new System.EventHandler(this.lviResults_SelectedIndexChanged);
            // 
            // txtCurrentResult
            // 
            this.txtCurrentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentResult.Location = new System.Drawing.Point(228, 6);
            this.txtCurrentResult.Multiline = true;
            this.txtCurrentResult.Name = "txtCurrentResult";
            this.txtCurrentResult.ReadOnly = true;
            this.txtCurrentResult.Size = new System.Drawing.Size(464, 397);
            this.txtCurrentResult.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 545);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.btnExecute);
            this.Name = "FrmMain";
            this.Text = "Leftware Template Util";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpSourceInline.ResumeLayout(false);
            this.grpSourceFile.ResumeLayout(false);
            this.grpSourceFile.PerformLayout();
            this.grpSourceDatabase.ResumeLayout(false);
            this.grpSourceDatabase.PerformLayout();
            this.tbc.ResumeLayout(false);
            this.tbpSource.ResumeLayout(false);
            this.tbpSource.PerformLayout();
            this.tbpTemplate.ResumeLayout(false);
            this.tbpTemplate.PerformLayout();
            this.tbpResults.ResumeLayout(false);
            this.tbpResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox cboSourceType;
        private System.Windows.Forms.Label lblSourceType;
        private System.Windows.Forms.ComboBox cboSourceFormat;
        private System.Windows.Forms.Label lblSourceFormat;
        private System.Windows.Forms.GroupBox grpSourceInline;
        private System.Windows.Forms.GroupBox grpSourceFile;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.Button btnFileLoad;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.GroupBox grpSourceDatabase;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbpSource;
        private System.Windows.Forms.TabPage tbpTemplate;
        private System.Windows.Forms.TabPage tbpResults;
        private System.Windows.Forms.ListView lviResults;
        private System.Windows.Forms.TextBox txtCurrentResult;
        private ScintillaNET.Scintilla sciTemplate;
        private System.Windows.Forms.Panel pnlSourceType;
        private ScintillaNET.Scintilla sciSource;
        private System.Windows.Forms.ComboBox cboDbType;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblDbType;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.ComboBox cboTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenTemplateFolder;
        private System.Windows.Forms.Button btnExportAs;
        private System.Windows.Forms.ComboBox cboExportAs;
        private System.Windows.Forms.Label lblExportAs;
        private ScintillaNET.Scintilla sciQuery;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Button btnSaveSource;
        private System.Windows.Forms.Button btnLoadSource;
        private System.Windows.Forms.Button btnOpenSourceFolder;
    }
}

