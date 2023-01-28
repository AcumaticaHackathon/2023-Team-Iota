#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------
#endregion

namespace AcuConvert.Core.Models
{
    public class SyncConnection
    {
        public AcumaticaConnectionContext AcumaticaConnectionContext { get; set; }
        public LegacyConnectionContext    LegacyConnectionContext    { get; set; }
        
    }
}