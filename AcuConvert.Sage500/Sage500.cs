using AcuConvert.Core;
using AcuConvert.Core.Models;

using AcuConvert.Core.Models.Data;
using System.Data;
using System.Data.SqlClient;
using AcuConvert.Core.Models.Data;

namespace AcuConvert.Sage500;

public class Sage500 : AcuConvert.Core.Interfaces.ILegacyConnector //AcuConvert.Core.Interfaces
{
    public IEnumerable<Row> GetDataSet(LegacyConnectionContext type, DateTime lastRunDate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Field> GetSchema(LegacyConnectionContext type)
    {

        string connectionString = null;
        SqlConnection sqlCnn;
        SqlCommand sqlCmd;
        List<Field> returnfields = new List<Field>();

        string sql = type.Query;
        //Datasource
        //InitCatalog
        //UserID
        //Password
        string datasource = type.AuthenticationValues["Datasource"];
        string initcat = type.AuthenticationValues["InitCatalog"];
        string userID = type.AuthenticationValues["UserID"];
        string password = type.AuthenticationValues["Password"];

        connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", datasource,initcat, userID, password);

        sqlCnn = new SqlConnection(connectionString);
        try
        {
            sqlCnn.Open();
            sqlCmd = new SqlCommand(sql, sqlCnn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            DataTable schemaTable = sqlReader.GetSchemaTable();

            foreach (DataRow row in schemaTable.Rows)
            {
                    // add entry to ReturnFields list for each

                    // need to map db data types to TypeCode
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
