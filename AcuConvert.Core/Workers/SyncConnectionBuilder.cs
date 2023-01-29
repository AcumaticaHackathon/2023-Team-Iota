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

namespace AcuConvert.Core.Workers
{
    public class SyncConnectionBuilder
    {
        private readonly ISyncRepository _repository;

        public SyncConnectionBuilder(ISyncRepository repository)
        {
            _repository = repository;
        }

        public SyncConnection BuildConnection(string instanceID)
        {
            var syncConnection           = new SyncConnection();
            var sourceConnectionSettings = _repository.GetSourceConnectionSettings();
            var sourceQuerySettings      = _repository.GetInstanceQuerySettings(instanceID);
            syncConnection.LegacyConnectionContext = new LegacyConnectionContext()
            {
                AuthenticationValues = sourceConnectionSettings.ToArray(),
                QueryParameters = sourceQuerySettings.ToArray()
            };
            syncConnection.AcumaticaConnectionContext = _repository.GetDestConnectionSettings();
            syncConnection.LastRun                    = _repository.GetSyncInstance(instanceID).LastRun ?? new DateTime(1900,1,1);
            
            return syncConnection;
        }
    }
}