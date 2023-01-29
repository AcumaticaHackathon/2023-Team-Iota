using AcuConvert.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuConvert.Core
{
    internal class JsonFileReader : IJasonInput
    {
        public string GetSwaggerJsonString()
        {
            string json = "";
            using (StreamReader r = new StreamReader(@"..\..\..\..\AcuConvert.Acumatica\SampleJson\sample-swagger.json"))
            {
                json = r.ReadToEnd();
            }

            return json;
        }
    }
}
