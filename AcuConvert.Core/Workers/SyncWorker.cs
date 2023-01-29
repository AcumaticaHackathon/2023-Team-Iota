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
    public class SyncWorker : ISyncWorker
    {
        public SyncWorker()
        {
            
        }
        
        public void PrepareData(SyncConnection connection)
        {
            throw new NotImplementedException();
        }

        public void ProcessData(SyncConnection connection)
        {
            throw new NotImplementedException();
        }
    }
}