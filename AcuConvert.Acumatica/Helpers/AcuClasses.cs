#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------
#endregion

using Newtonsoft.Json.Linq;

namespace AcuConvert.Acumatica.Helpers
{
    public static class JobjectExt
    {
        public static void AddStringValue(this JObject jObject, string propertyName, string value)
        {
            var stringValue = new JObject();
            stringValue.Add(new JProperty("Value", value));
            jObject.Add(stringValue);
        }
        public static void AddBoolValue(this JObject jObject, string propertyName, string value)
        {
            bool? boolValue = null;
            if (!string.IsNullOrWhiteSpace(value))
            {
                if (!bool.TryParse(value, out bool parsedBoolValue))
                {
                    throw new InvalidOperationException("Object is not bool value");
                }

                boolValue = parsedBoolValue;
            }

            var boolObject = new JObject();
            boolObject.Add(new JProperty("Value", boolValue));
            jObject.Add(propertyName, boolObject);
        }
        public static void AddDecimalValue(this JObject jObject, string propertyName, string value)
        {
            bool? boolValue = null;
            if (!string.IsNullOrWhiteSpace(value))
            {
                if (!bool.TryParse(value, out bool parsedBoolValue))
                {
                    throw new InvalidOperationException("Object is not bool value");
                }

                boolValue = parsedBoolValue;
            }

            var boolObject = new JObject();
            boolObject.Add(new JProperty("Value", boolValue));
            jObject.Add(propertyName, boolObject);
        }
        public static void AddIntValue(this JObject jObject, string propertyName, string value)
        {
            int? boolValue = null;
            if (!string.IsNullOrWhiteSpace(value))
            {
                if (!int.TryParse(value, out int parsedBoolValue))
                {
                    throw new InvalidOperationException("Object is not bool value");
                }

                boolValue = parsedBoolValue;
            }

            var boolObject = new JObject();
            boolObject.Add(new JProperty("Value", boolValue));
            jObject.Add(propertyName, boolObject);
        }
    }
}