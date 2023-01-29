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
        public string InstanceID   { get; set; }
        public int    RowNbr       { get; set; }
        public Guid   NoteID       { get; set; }
        public byte   Failed       { get; set; }
        public string ErrorMessage { get; set; }
    }
}