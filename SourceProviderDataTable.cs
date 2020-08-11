using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;

namespace Leftware.Utils.TemplateUtil
{
    internal class SourceProviderDataTable : SourceProviderBase
    {
        public override IEnumerable<object> GetSource(SourceType sourceType, ISourceData sourceData)
        {
            DataTable dt = GetDataTable(sourceType, sourceData);
            if (dt == null) yield break;

            var columns = dt.Columns.Cast<DataColumn>();

            foreach (DataRow dr in dt.Rows)
            {
                var result = columns.ToDictionary(c => c.ColumnName, c => dr[c]);
                yield return result;
            }
        }

        private DataTable GetDataTable(SourceType sourceType, ISourceData sourceData)
        {
            if (sourceType != SourceType.Database || !(sourceData is ISourceDatabase sourceDatabase)) return null;

            using (var cn = GetConnection(sourceDatabase))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = sourceDatabase.Query;
                    cn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }

        private IDbConnection GetConnection(ISourceDatabase sourceDatabase)
        {
            switch (sourceDatabase.DatabaseType)
            {
                case DatabaseType.SqlServer:
                    return new SqlConnection(sourceDatabase.ConnectionString);

                case DatabaseType.Sqlite:
                    return new SQLiteConnection(sourceDatabase.ConnectionString);

                default: return null;
            }
        }
    }
}