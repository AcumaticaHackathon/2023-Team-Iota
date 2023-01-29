#region #Copyright

//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------

#endregion

namespace AcuConvert.Core.Models.Data.DB
{
    public class SyncMapping
    {
        public int    MappingID   { get; set; }
        public string InstanceID  { get; set; }
        public bool      IsKey           { get; set; }
        public string SourceField { get; set; }
        public string DestField   { get; set; }
        public string SourceValue { get; set; }
    }
}