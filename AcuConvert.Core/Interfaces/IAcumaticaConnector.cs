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

namespace AcuConvert.Core.Interfaces
{
    public interface IAcumaticaConnector
    {
        void               Initialize(AcumaticaConnectionContext context);
        void               SendRow(Row                           row);
        IEnumerable<Field> GetSchema(string acuObject);
    }
}