using AcuConvert.Core;
using AcuConvert.Core.Models;
using System.Data;
using System.Data.SqlClient;
namespace AcuConvert.Sage500;

public class Sage500 : AcuConvert.Core.Interfaces.ILegacyConnector
{
    public IEnumerable<Row> GetDataSet(DateTime lastRunDate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Field> GetSchema(EntityType type)
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
                foreach (DataColumn column in schemaTable.Columns)
                {
                    // add entry to ReturnFields list for each

                    // need to map db data types to TypeCode
                    returnfields.Add(new Field(column.ColumnName, TypeCode.String, false));
                }
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
