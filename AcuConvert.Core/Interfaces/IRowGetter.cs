#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------
#endregion

using AcuConvert.Core.Models;

namespace AcuConvert.Core.Interfaces
{
    public interface ISyncWorker
    {
        void PrepareData(SyncConnection connection);
        void ProcessData(SyncConnection connection);
    }
}