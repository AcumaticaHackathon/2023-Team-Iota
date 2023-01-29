#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------
#endregion

using AcuConvert.Core.Interfaces;
using AcuConvert.Core.Models;
using AcuConvert.Core.Models.Data;

namespace AcuConvert.Persistence
{
    public class Repository : ISyncRepository
    {
        public IEnumerable<Field>                        GetSourceSchema(string instanceID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Row>                          GetSyncDataSet(string  instanceID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValuePair<string, string>> GetSourceConnectionSettings()
        {
            throw new NotImplementedException();
        }

        public AcumaticaConnectionContext                GetDestConnectionSettings()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValuePair<string, string>> GetInstanceQuerySettings(string instanceID)
        {
            throw new NotImplementedException();
        }

        public SyncInstance GetSyncInstance(string instanceID)
        {
            throw new NotImplementedException();
        }
    }
}