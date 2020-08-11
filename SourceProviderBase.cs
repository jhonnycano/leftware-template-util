using Scriban.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace Leftware.Utils.TemplateUtil
{
    public abstract class SourceProviderBase
    {
        public abstract IEnumerable<object> GetSource(SourceType sourceType, ISourceData sourceData);

        protected static IEnumerable<object> GetObjectEnumerable(object sourceObject, Type sourceType, string contextExpression)
        {
            if (string.IsNullOrEmpty(contextExpression))
            {
                if (sourceObject is IEnumerable e)
                {
                    foreach(var itm in e)
                    {
                        yield return itm;
                    }
                } 
                else
                {
                    yield return sourceObject;
                }

                yield break;
            }

            if (sourceType == null) sourceType = typeof(object);

            var par = Expression.Parameter(sourceType, "model");
            var lambda = DynamicExpressionParser.ParseLambda(new[] { par }, null, contextExpression);
            var c = lambda.Compile();
            var enumerable = (IEnumerable<object>)c.DynamicInvoke(sourceObject);
            foreach (var obj in enumerable)
            {
                yield return obj;
            }
        }

        protected static ScriptObject BuildScriptObject(ExpandoObject expando)
        {
            var dict = (IDictionary<string, object>)expando;
            var scriptObject = new ScriptObject();

            foreach (var kv in dict)
            {
                //var renamedKey = StandardMemberRenamer.Rename(kv.Key);
                var renamedKey = kv.Key;

                if (kv.Value is ExpandoObject expandoValue)
                {
                    scriptObject.Add(renamedKey, BuildScriptObject(expandoValue));
                }
                else
                {
                    scriptObject.Add(renamedKey, kv.Value);
                }
            }

            return scriptObject;
        }
    }
}