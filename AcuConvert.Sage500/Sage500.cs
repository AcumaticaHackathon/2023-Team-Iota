using AcuConvert.Core;
using AcuConvert.Core.Models;

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
        throw new NotImplementedException();
    }
}
