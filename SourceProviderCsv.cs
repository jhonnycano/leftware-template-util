using CsvHelper;
using Scriban.Runtime;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Leftware.Utils.TemplateUtil
{
    internal class SourceProviderCsv : SourceProviderBase
    {
        public override IEnumerable<object> GetSource(SourceType sourceType, ISourceData sourceData)
        {
            var csvText = GetCsv(sourceType, sourceData);
            using (var reader = new StringReader(csvText))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csvReader.Configuration.Delimiter = ",";
                csvReader.Configuration.HasHeaderRecord = false;
                csvReader.Configuration.MissingFieldFound = (a, b, c) => { };
                var records = csvReader.GetRecords<GenericCsvItem>();
                /*
                foreach(var r in records)
                {
                    yield return r;
                }
                */

                // var innerList = new List<ScriptObject>();
                foreach (var itm in records)
                {
                    // var scriptObject = new ScriptObject();
                    // scriptObject.Import(itm);
                    yield return itm;
                }

                /*
                */
                // var list = GetObjectEnumerable(records, null, null);
                // return list;
            }
        }

        private string GetCsv(SourceType sourceType, ISourceData sourceData)
        {
            if (sourceType == SourceType.Inline && sourceData is ISourceInline sourceInline) return sourceInline.Content;
            if (sourceType == SourceType.File && sourceData is ISourceFile sourceFile) return File.ReadAllText(sourceFile.FilePath);
            return "";
        }
    }
}