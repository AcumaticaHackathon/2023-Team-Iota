#region #Copyright

//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------

#endregion

namespace AcuConvert.Core.Models.Data
{
    public class Row
    {
        public Row(string instanceId, int rowNbr)
        {
            InstanceID = instanceId;
            RowNbr     = rowNbr;
            _fields    = new Dictionary<string, Field>();
        }

        public string InstanceID { get; }
        public int    RowNbr     { get; }
        public Guid?  NoteId     { get; set; }

        public ICollection<KeyValuePair<string, Field>> KeyFields =>
            _fields.Where(f => f.Key.StartsWith("!")).ToArray();

        public Dictionary<string, Field> Fields    => _fields;
        public bool                      Failed    { get; set; } = false;
        public string                    ErrorText { get; set; } = string.Empty;
        public bool                      Processed { get; set; } = false;

        public void AddField(Field field)
        {
            string key = field.IsKey ? "!" + field.FieldName.Trim() : field.FieldName.Trim();
            if (!_fields.TryAdd(key, field))
            {
                throw new InvalidOperationException("Field already exists");
            }
        }

        private Dictionary<string, Field> _fields;
    }
}