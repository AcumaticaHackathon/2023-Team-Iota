using System.Dynamic;
using System.Net;
using System.Text.RegularExpressions;
using AcuConvert.Acumatica.Helpers;
using AcuConvert.Acumatica.Interfaces;
using AcuConvert.Core.Interfaces;
using AcuConvert.Core.Models;
using AcuConvert.Core.Models.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace AcuConvert.Acumatica
{
    public class AcumaticaConnector : IAcumaticaConnector, IDisposable
    {
        private RestClient                 _client;
        private AcumaticaConnectionContext _context;

        public void Initialize(AcumaticaConnectionContext context)
        {
            _context = context;
            _client = new RestClient(new RestClientOptions(context.BaseURL + "/")
                {CookieContainer = new CookieContainer()});
            var request = new RestRequest("entity/auth/login", Method.Post);
            request.AddJsonBody(new
            {
                name     = context.Username,
                password = context.Password,
                company  = context.Company
            });
            var response = _client.Execute(request);
            if (!response.IsSuccessful) throw new InvalidOperationException("Could not connect to Acumatica");
        }

        public void SendRow(Row row)
        {
            JObject acuRow = new JObject();

            foreach (var field in row.Fields)
            {
                // Try to see if we have a sub class
                JObject workingWith = acuRow;
                var     match       = Regex.Match(field.Value.FieldName, @"(?<name>\w+)\/");
                if (match.Success)
                {
                    // We need to make a sub object
                    if (!acuRow.TryGetValue(match.Groups["name"].Value,
                            StringComparison.OrdinalIgnoreCase, out JToken? existingObj))
                    {
                        workingWith = new JObject();
                        acuRow.Add(match.Groups["name"].Value, workingWith);
                    }
                }

                switch (field.Value.DataType)
                {
                    case "String":
                        workingWith.AddStringValue(field.Value.FieldName, field.Value.Value);
                        break;
                }
            }

            var putRequest = row.NoteId.HasValue
                ? new RestRequest($"entity/{_context.EndpointName}/{_context.EndpointVersion}/" + _context.Resource + "/" +row.NoteId, Method.Put) // Update
                : new RestRequest($"entity/{_context.EndpointName}/{_context.EndpointVersion}/" + _context.Resource, Method.Put); // Insert
            putRequest.AddJsonBody(acuRow.ToString());
            var response = _client.Execute(putRequest);
            if (!response.IsSuccessful)
            {
                throw new HttpRequestException();
            }
        }

        IEnumerable<Field> IAcumaticaConnector.GetSchema(string acuObject)
        {
            IJasonInput jasonInput = new JsonFileReader();
            string      json       = jasonInput.GetSwaggerJsonString();


            // to be tested for dynamic select
            var jsonDom = JsonConvert.DeserializeObject<JObject>(json)!;
            var toBeTestted = jsonDom.SelectToken(string.Format("$.definitions.{0}.allOf[1].properties", acuObject))!
                                     .ToArray();

            foreach (var p in toBeTestted)
            {
                // var r =p.;
            }

            // with hardcoded
            dynamic                     dynamicObject = JsonConvert.DeserializeObject<ExpandoObject>(json)!;
            IDictionary<string, object> properties    = dynamicObject.definitions.Customer.allOf[1].properties;

            var fields = new List<Field>();

            foreach (var prop in properties)
            {
                IDictionary<string, object> valeObject      = (IDictionary<string, object>) prop.Value;
                var                         typeValueString = valeObject.First().Value as string;
                fields.Add(new Field(prop.Key, TypeUtil.GetTypeCode(typeValueString), false));
            }

            return fields;
        }

        public void Dispose()
        {
            var request = new RestRequest("entity/auth/logout", Method.Post);
            _client.Execute(request);
            _client.Dispose();
        }
    }
}