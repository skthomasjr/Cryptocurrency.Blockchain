﻿using System;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain.Serialization.Converters
{
    internal class UnixTimeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return DateTimeOffset.FromUnixTimeSeconds((long) reader.Value).UtcDateTime;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, new DateTimeOffset((DateTime) value).ToUnixTimeSeconds());
        }
    }
}