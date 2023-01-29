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
    public class LegacyConnectionContext
    {
        public LegacyConnectionContext()
        {
            AuthenticationValues = new List<KeyValuePair<string, string>>();
            QueryParameters      = new List<KeyValuePair<string, string>>();
        }

        public ICollection<KeyValuePair<string, string>> AuthenticationValues { get; set; }
        public ICollection<KeyValuePair<string, string>> QueryParameters { get; set; }
    }
}