using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuConvert.Core.Helpers
{
    public class TypeUtil
    {
        public static TypeCode GetTypeCode(string typeValue) 
        {
            typeValue = typeValue.Replace("#/definitions/", "");

            switch (typeValue)
            {
                case "StringValue":
                    return TypeCode.String;
                case "BooleanValue":
                    return TypeCode.Boolean;
                case "DecimalValue":
                    return TypeCode.Decimal;
                case "DateTimeValue":
                    return TypeCode.DateTime;
                case "IntValue":
                    return TypeCode.Int32;
                case "ShortValue":
                    return TypeCode.Int16;
                case "ByteValue":
                    return TypeCode.Byte;
                case "DoubleValue":
                    return TypeCode.Double;
                case "GuidValue":
                    return TypeCode.String;
                default:
                    return TypeCode.String;
            }

        }
    }
}
