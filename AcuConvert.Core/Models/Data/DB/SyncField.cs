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
    public class SyncField
    {
        public string InstanceID      { get; set; }
        public int    RowNbr          { get; set; }
        public string SourceFieldName { get; set; }
        public string DataType        { get; set; }
        public string Value           { get; set; }
        public bool      IsKey               { get; set; }
    }
}