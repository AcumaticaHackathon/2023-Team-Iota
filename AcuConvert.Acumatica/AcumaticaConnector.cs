using AcuConvert.Core.Helpers;
using AcuConvert.Core.Interfaces;
using AcuConvert.Core.Models;
using AcuConvert.Core.Models.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace AcuConvert.Core
{
    public class AcumaticaConnector : IAcumaticaConnector
    {

        public void Initialize(AcumaticaConnectionContext context)
        {
            throw new NotImplementedException();
        }

        public void SendRow(Row row)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Field> IAcumaticaConnector.GetSchema(string acuObject)
        {
            IJasonInput jasonInput = new JsonFileReader();
            string json = jasonInput.GetSwaggerJsonString();


            // to be tested for dynamic select
            var jsonDom = JsonConvert.DeserializeObject<JObject>(json)!;
            var toBeTestted = jsonDom.SelectToken(string.Format("$.definitions.{0}.allOf[1].properties", acuObject))!.ToArray();

            foreach (var p in toBeTestted) 
            {
               // var r =p.;
            }

            // with hardcoded
            dynamic dynamicObject = JsonConvert.DeserializeObject<ExpandoObject>(json)!;
            IDictionary<string, object> properties = dynamicObject.definitions.Customer.allOf[1].properties;

            var fields = new List<Field>();

            foreach (var prop in properties)
            {
                IDictionary<string, object> valeObject = (IDictionary<string, object>)prop.Value;
                var typeValueString = valeObject.First().Value as string;
                fields.Add(new Field(prop.Key, TypeUtil.GetTypeCode(typeValueString), false));
            }

            return fields;
        }
    }
}
