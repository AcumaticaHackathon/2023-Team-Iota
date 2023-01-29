using AcuConvert.Core.Models;
using RestSharp;

namespace AcuConvert.Acumatica.Interfaces
{
    internal interface IJasonInput
    {
        string GetSwaggerJsonString(AcumaticaConnectionContext context, RestClient client);
    }
}
