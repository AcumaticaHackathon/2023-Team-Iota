#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------
#endregion

using AcuConvert.Core.Models;
using AcuConvert.Core.Models.Data;

namespace AcuConvert.Core.Workers
{
    public class RecordReconciliator
    {
        public void SyncRow(IDictionary<int, Row> dataSet, Row newRow)
        {
            var existingRow = dataSet.FirstOrDefault(row =>
                row.Value.KeyFields.All(rowKeyField =>
                    newRow.KeyFields.FirstOrDefault(newRowFields =>
                        newRowFields.Key == rowKeyField.Key).Value == rowKeyField.Value));
            
            if (existingRow.Equals(default(KeyValuePair<int,Row>)))
            {
                // Insert
                dataSet.Add(dataSet.Count + 1, newRow);
                return;
            }
            
            // Update
            foreach (KeyValuePair<string,Field> field in existingRow.Value.Fields)
            {
                // Set each field property
                field.Value.Value = newRow.Fields[field.Key].Value;
            }
        }
    }
}