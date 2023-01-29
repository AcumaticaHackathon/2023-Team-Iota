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
    public class Field
    {
        public Field(string fieldName, string dataType, bool isKey)
        {
            if(string.IsNullOrWhiteSpace(fieldName)) throw new ArgumentNullException(nameof(fieldName));
            if(string.IsNullOrWhiteSpace(dataType)) throw new ArgumentNullException(nameof(dataType));

            FieldName = fieldName;
            DataType  = dataType;
            IsKey     = isKey;
        }

        public string   FieldName { get; }
        public string DataType  { get; }
        public bool     IsKey     { get; }
        public string   Value     { get; set; }
    }
}