#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------
#endregion

using AcuConvert.Core.Models;
using AcuConvert.Core.Models.Data;

namespace AcuConvert.Core.Interfaces
{
    public interface ISyncRepository
    {
        IEnumerable<Field>                        GetSourceSchema(string instanceID);
        IEnumerable<Row>                          GetSyncDataSet(string  instanceID);
        IEnumerable<KeyValuePair<string, string>> GetSourceConnectionSettings();
        IEnumerable<KeyValuePair<string, string>> GetInstanceQuerySettings(string instanceID);
    }
}