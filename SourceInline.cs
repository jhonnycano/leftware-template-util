namespace Leftware.Utils.TemplateUtil
{
    public interface ISourceData
    {
    }

    public interface ISourceInline : ISourceData
    {
        string Content { get; }
    }

    public interface ISourceFile : ISourceData
    {
        string FilePath { get; }
    }

    public interface ISourceDatabase : ISourceData
    {
        DatabaseType DatabaseType { get; }
        string ConnectionString { get; }
        string Query { get; }
    }
}