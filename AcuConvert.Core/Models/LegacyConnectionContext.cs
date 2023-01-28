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
        public LegacyConnectionContext(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) throw new ArgumentNullException(nameof(query));
            Query = query;
        }

        public Dictionary<string, string> AuthenticationValues { get; set; } = new();
        public string                     Query                { get;  }
    }
}