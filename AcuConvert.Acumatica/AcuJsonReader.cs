#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/29
// ----------------------------------------------------------------------------------
#endregion

using AcuConvert.Acumatica.Interfaces;
using AcuConvert.Core.Models;
using RestSharp;

namespace AcuConvert.Acumatica
{
    public class AcuJsonReader : IJasonInput
    {
        public string GetSwaggerJsonString(AcumaticaConnectionContext context, RestClient client)
        {
            var request  = new RestRequest("entity/Demo/1.0/swagger.json", Method.Get);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}