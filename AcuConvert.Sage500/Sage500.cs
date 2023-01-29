using AcuConvert.Core;
using AcuConvert.Core.Models;

using AcuConvert.Core.Models.Data;
using System.Data;
using System.Data.SqlClient;
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

        string sql = null;

        connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
        sql = "Select * from product";

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
                    returnfields.Add(new Field(row["ColumnName"].ToString(), TypeCode.String, false));
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
