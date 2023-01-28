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
    public class Row
    {
        public Guid?       NoteId { get; set; }
        public List<Field> Fields { get; set; } = new();
    }
}