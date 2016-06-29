using System;
using System.Net;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain.Serialization.Converters
{
    internal class IpAddressConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IPAddress);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var ipAddress = reader.Value.ToString();
            return string.IsNullOrWhiteSpace(ipAddress) ? null : IPAddress.Parse(ipAddress);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var ipAddress = (IPAddress) value;
            if (ipAddress != null) writer.WriteValue(ipAddress.ToString());
        }
    }
}