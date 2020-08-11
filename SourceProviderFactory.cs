namespace Leftware.Utils.TemplateUtil
{
    public class SourceProviderFactory
    {
        public SourceProviderFactory()
        {
        }

        public SourceProviderBase GetSourceProvider(SourceFormat sourceFormat)
        {
            switch (sourceFormat)
            {
                case SourceFormat.JsonObject:
                    return new SourceProviderJsonObject();

                case SourceFormat.JsonArray:
                    return new SourceProviderJsonArray();

                case SourceFormat.Csv:
                    return new SourceProviderCsv();

                case SourceFormat.DataTable:
                    return new SourceProviderDataTable();
            }

            return null;
        }
    }
}