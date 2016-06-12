//using Newtonsoft.Json;
//using System;

//namespace Cryptocurrency.Blockchain.Serialization.Converters
//{
//    public class NullableDateTimeConverter : JsonConverter
//    {
//        public override bool CanConvert(Type objectType)
//        {
//            return objectType == typeof(DateTime?);
//        }

//        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
//        {
//            var unixTime = (long)reader.Value;
//            if (unixTime == 0) return null;
//            return DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
//        }

//        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
//        {
//            var typedValue = (DateTime?)value;
//            if (typedValue.HasValue)
//            {
//                serializer.Serialize(writer, new DateTimeOffset(typedValue.Value).ToUnixTimeSeconds());
//            }
//            else
//            {
//                serializer.Serialize(writer, 0);
//            }
//        }
//    }
//}