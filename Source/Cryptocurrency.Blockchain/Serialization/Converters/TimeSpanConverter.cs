//using Newtonsoft.Json;
//using System;

//namespace Cryptocurrency.Blockchain.Serialization.Converters
//{
//    public class TimeSpanConverter : JsonConverter
//    {
//        public override bool CanConvert(Type objectType)
//        {
//            return objectType == typeof(TimeSpan);
//        }

//        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
//        {
//            return TimeSpan.FromSeconds((long)reader.Value);
//        }

//        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
//        {
//            serializer.Serialize(writer, ((TimeSpan)value).TotalSeconds);
//        }
//    }
//}