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
    public class SyncRow
    {
        public bool   Selected     { get; set; } = false;
        public string InstanceID   { get; set; }
        public int    RowNbr       { get; set; }
        public string NoteID       { get; set; }
        public bool   Failed       { get; set; }
        public string ErrorMessage { get; set; }
        public bool   Processed    { get; set; }
    }
}