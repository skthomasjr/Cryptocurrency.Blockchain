using Newtonsoft.Json;
using System;
using System.Text;

namespace Cryptocurrency.Blockchain.Serialization.Converters
{
    public class ByteArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(byte[]);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var encodedValue = reader.Value.ToString();
            return ASCIIEncoding.ASCII.GetBytes(encodedValue);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var decodedValue = ASCIIEncoding.ASCII.GetChars((byte[])value).ToString();
            serializer.Serialize(writer, decodedValue);
        }
    }
}