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
    public class Field
    {
        public Field(string fieldName, TypeCode dataType, bool isKey)
        {
            FieldName = fieldName ?? throw new ArgumentNullException(nameof(fieldName));
            DataType  = dataType;
            IsKey     = isKey;
        }

        public string   FieldName { get; }
        public TypeCode DataType  { get; }
        public bool     IsKey     { get; }
        public object   Value     { get; set; }
    }
}