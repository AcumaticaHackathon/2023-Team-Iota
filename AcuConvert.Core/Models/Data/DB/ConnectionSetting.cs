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
    public class ConnectionSetting
    {
        public bool   IsDest    { get; set; }
        public string SettingID { get; set; }
        public string Value     { get; set; }
    }
}