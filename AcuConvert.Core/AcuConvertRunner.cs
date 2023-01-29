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
using AcuConvert.Core.Workers;

namespace AcuConvert.Core
{
    public class AcuConvertRunner
    {
        private readonly ILegacyConnector    _legacyConnector;
        private readonly IAcumaticaConnector _acuConnector;
        private readonly RecordReconciliator _reconciliator;

        public AcuConvertRunner(ILegacyConnector    legacyConnector,
                                IAcumaticaConnector acuConnector,
                                RecordReconciliator reconciliator)
        {
            _legacyConnector = legacyConnector;
            _acuConnector    = acuConnector;
            _reconciliator   = reconciliator;
        }
        
        public void Prepare(SyncConnection connection)
        {
            var legacyDataSet   = _legacyConnector.GetDataSet(connection.LegacyConnectionContext, connection.LastRun);
            foreach (Row row in legacyDataSet)
            {
                _reconciliator.SyncRow(connection.Rows, row);
            }
        }
        
        public void Process(SyncConnection connection)
        {
            foreach (var row in connection.Rows)
            {
                try
                {
                    _acuConnector.SendRow(row.Value);
                    row.Value.Processed = true;
                }
                catch (Exception e)
                {
                    row.Value.Failed    = true;
                    row.Value.ErrorText = e.Message;
                }
            }
        }
    }
}