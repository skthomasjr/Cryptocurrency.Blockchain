using System;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain.Serialization.Converters
{
    internal class SatoshiValueJsonConverter : JsonConverter
    {
        private const decimal satoshisPerBitcoin = 100000000;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(decimal);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var bitcoinValue = decimal.Parse(reader.Value.ToString())/satoshisPerBitcoin;
            return bitcoinValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var bitcoinValue = decimal.Parse(value.ToString())*satoshisPerBitcoin;
            writer.WriteValue(bitcoinValue);
        }
    }
}