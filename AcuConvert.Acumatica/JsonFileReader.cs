using AcuConvert.Acumatica.Interfaces;

namespace AcuConvert.Acumatica
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
