namespace Leftware.Utils.TemplateUtil.Model
{
    public class EnvironmentModel
    {
        public TemplateSourceModel TemplateModel { get; set; }
        public string TemplateContent { get; set; }
        public ExportMode ResultExportAs { get; set; }
        public SelectableTab CurrentTab { get; set; }
    }
}
