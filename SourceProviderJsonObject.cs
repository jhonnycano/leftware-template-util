using Newtonsoft.Json;
using Scriban.Runtime;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

namespace Leftware.Utils.TemplateUtil
{
    public class SourceProviderJsonObject : SourceProviderBase
    {
        public override IEnumerable<object> GetSource(SourceType sourceType, ISourceData sourceData)
        {
            var json = GetJson(sourceType, sourceData);
            var expando = JsonConvert.DeserializeObject<ExpandoObject>(json);
            var src = BuildScriptObject(expando);

            var list = GetObjectEnumerable(src, null, null);
            return list;
        }

        private string GetJson(SourceType sourceType, ISourceData sourceData)
        {
            if (sourceType == SourceType.Inline && sourceData is ISourceInline sourceInline) return sourceInline.Content;
            if (sourceType == SourceType.File && sourceData is ISourceFile sourceFile) return File.ReadAllText(sourceFile.FilePath);
            return "";
        }
    }

}