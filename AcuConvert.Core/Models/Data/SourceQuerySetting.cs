﻿#region #Copyright

//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------

#endregion

namespace AcuConvert.Core.Models.Data
{
    public class SourceQueryString
    {
        public string InstanceID { get; set; }
        public string SettingID  { get; set; }
        public string Value      { get; set; }
    }
}