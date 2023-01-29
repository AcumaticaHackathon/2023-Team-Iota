using AcuConvert.Core;
using AcuConvert.Core.Models;

using AcuConvert.Core.Models.Data;
using System.Data;
using System.Data.SqlClient;


namespace AcuConvert.Sage500;

//        IEnumerable<Field> GetSchema(LegacyConnectionContext type);
public class Sage500 : AcuConvert.Core.Interfaces.ILegacyConnector //AcuConvert.Core.Interfaces
{
    public IEnumerable<Row> GetDataSet(LegacyConnectionContext type, DateTime lastRunDate)
    {

        string connectionString = null;
        SqlConnection sqlCnn;
        SqlCommand sqlCmd;
        List<Row> returnrows = new List<Row>();

        string sql = type
                           .QueryParameters.FirstOrDefault(v =>
                                string.Equals(v.Key, "Query", StringComparison.OrdinalIgnoreCase)).Value;
        
        string lastmodifiedfield = type.QueryParameters.FirstOrDefault(v => string.Equals(v.Key, "LastModifiedField",StringComparison.OrdinalIgnoreCase)).Value;

        sql = sql + " and " + lastmodifiedfield + " > '" + lastRunDate + "'";

        sqlCnn = MakeSqlConnection(type);
        try
        {
            sqlCnn.Open();
            sqlCmd = new SqlCommand(sql, sqlCnn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            int rowcnt = 0;

            if (sqlReader.HasRows)
            {
                while(sqlReader.Read())
                {
                    rowcnt++;

                    Row r = new Row(String.Empty,rowcnt);

                    //read rows
                    for (int i = 0; i < sqlReader.FieldCount; i++)
                    {
                        Field f = new Field(sqlReader.GetName(i), sqlReader.GetValue(i).GetType().ToString(), false);
                        f.Value = sqlReader.GetValue(i).ToString();

                        r.AddField(f);
                    }
                    
                    returnrows.Add(r);
                }
            }
            
            sqlReader.Close();
            sqlCmd.Dispose();
            sqlCnn.Close();
            
            return returnrows;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    private static SqlConnection MakeSqlConnection(LegacyConnectionContext type)
    {
        //Datasource
        //InitCatalog
        //UserID
        //Password
        string        connectionString;
        SqlConnection sqlCnn;
        string datasource = type
                           .AuthenticationValues.FirstOrDefault(v =>
                                string.Equals(v.Key, "Datasource", StringComparison.OrdinalIgnoreCase)).Value;
        string initcat = type
                        .AuthenticationValues.FirstOrDefault(v =>
                             string.Equals(v.Key, "initcat", StringComparison.OrdinalIgnoreCase)).Value;
        string userID = type
                       .AuthenticationValues.FirstOrDefault(v =>
                            string.Equals(v.Key, "userID", StringComparison.OrdinalIgnoreCase)).Value;
        string password = type
                         .AuthenticationValues.FirstOrDefault(v =>
                              string.Equals(v.Key, "password", StringComparison.OrdinalIgnoreCase)).Value;

        connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", datasource,
            initcat, userID, password);

        sqlCnn = new SqlConnection(connectionString);
        return sqlCnn;
    }


    public IEnumerable<Field> GetSchema(LegacyConnectionContext type)
    {
        string connectionString = null;
        SqlConnection sqlCnn;
        SqlCommand sqlCmd;
        List<Field> returnfields = new List<Field>();

        string sql = type
                    .QueryParameters.FirstOrDefault(v =>
                         string.Equals(v.Key, "Query", StringComparison.OrdinalIgnoreCase)).Value;
        sqlCnn = MakeSqlConnection(type);
        try
        {
            sqlCnn.Open();
            sqlCmd = new SqlCommand(sql, sqlCnn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            DataTable schemaTable = sqlReader.GetSchemaTable();

            foreach (DataRow row in schemaTable.Rows)
            {
                // add entry to ReturnFields list for each

                returnfields.Add(new Field(row["ColumnName"].ToString(), row["DataType"].ToString(), false));
            }
            sqlReader.Close();
            sqlCmd.Dispose();
            sqlCnn.Close();


            return returnfields;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
