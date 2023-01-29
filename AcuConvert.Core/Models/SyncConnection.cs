#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------
#endregion

using AcuConvert.Core.Models.Data;

namespace AcuConvert.Core.Models
{
    public class SyncConnection
    {
        public AcumaticaConnectionContext AcumaticaConnectionContext { get; set; }
        public LegacyConnectionContext    LegacyConnectionContext    { get; set; }
        public DateTime                          LastRun                          { get; set; }
        public Dictionary<int,Row>        Rows                       { get; set; }
    }
}