namespace AcuConvert.Acumatica.Helpers
{
    public class TypeUtil
    {
        public static string GetTypeCode(string typeValue) 
        {
            typeValue = typeValue.Replace("#/definitions/", "");

            switch (typeValue)
            {
                case "StringValue":
                    return TypeCode.String.ToString();
                case "BooleanValue":
                    return TypeCode.Boolean.ToString();
                case "DecimalValue":
                    return TypeCode.Decimal.ToString();
                case "DateTimeValue":
                    return TypeCode.DateTime.ToString();
                case "IntValue":
                    return TypeCode.Int32.ToString();
                case "ShortValue":
                    return TypeCode.Int16.ToString();
                case "ByteValue":
                    return TypeCode.Byte.ToString();
                case "DoubleValue":
                    return TypeCode.Double.ToString();
                case "GuidValue":
                    return TypeCode.String.ToString();
                default:
                    return TypeCode.String.ToString();
            }

        }
    }
}
