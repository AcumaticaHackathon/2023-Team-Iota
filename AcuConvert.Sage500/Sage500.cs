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

        string sql = type.Query;
        //Datasource
        //InitCatalog
        //UserID
        //Password
        string datasource = type.AuthenticationValues["Datasource"];
        string initcat = type.AuthenticationValues["InitCatalog"];
        string userID = type.AuthenticationValues["UserID"];
        string password = type.AuthenticationValues["Password"];

        connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", datasource, initcat, userID, password);

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
                //returnfields.Add(new Field(row["ColumnName"].ToString(), row["DataType"].ToString(), false));
            }

            if (sqlReader.HasRows)
            {
                while(sqlReader.Read())
                {
                    Row r = new Row("Asdf",1);

                    //read rows
                    for (int i = 0; i < sqlReader.FieldCount; i++)
                    {
                        Field f = new Field(sqlReader.GetName(i), sqlReader.GetDataTypeName(i), false);
                        f.Value = sqlReader.GetValue(i);

                        r.Fields.Add(f.FieldName,f);
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

        connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", datasource, initcat, userID, password);

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
