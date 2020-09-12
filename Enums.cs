namespace Leftware.Utils.TemplateUtil
{
    public enum SourceType { Inline, File, Database }

    public enum SourceFormat { JsonArray, JsonObject, Csv, DataTable }

    public enum DatabaseType { SqlServer, Sqlite }

    public enum AppFolder { Templates, Sources,
        Environment
    }

    public enum ExportMode { ClipboardSeparatedText, FileJsonArray, FolderTextFiles }

    public enum SelectableTab { Source, Template, Results }
}