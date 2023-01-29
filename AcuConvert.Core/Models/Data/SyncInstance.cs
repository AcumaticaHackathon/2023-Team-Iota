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
    public class SyncInstance
    {
        public string   InstanceID         { get; set; }
        public string   Descr              { get; set; }
        public int      LastRowNbr         { get; set; }
        public DateTime LastRun            { get; set; }
        public string   PluginName         { get; set; }
        public string   AcuEndpointName    { get; set; }
        public string   AcuEndpointVersion { get; set; }
        public string   AcuResourceName    { get; set; }
        public string   AcuObjectName      { get; set; }
    }
}