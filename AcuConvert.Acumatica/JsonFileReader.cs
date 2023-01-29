using AcuConvert.Acumatica.Interfaces;
using AcuConvert.Core.Interfaces;
using AcuConvert.Core.Models;
using RestSharp;

namespace AcuConvert.Acumatica
{
    internal class JsonFileReader : IJasonInput
    {
        public string GetSwaggerJsonString(AcumaticaConnectionContext context, RestClient client)
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
