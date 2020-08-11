namespace Leftware.Utils.TemplateUtil
{
    internal class TemplateSourceModel
    {
        public SourceType SourceType { get; set; }
        public SourceFormat SourceFormat { get; set; }
        public string Content { get; set; }
        public string FilePath { get; set; }
        public DatabaseType DatabaseType { get; set; }
        public string ConnectionString { get; set; }
        public string Query { get; set; }
    }
}