using System;
using System.Text;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain.Serialization.Converters
{
    /// <summary>
    ///     Class ByteArrayConverter.
    /// </summary>
    public class ByteArrayConverter : JsonConverter
    {
        /// <summary>
        ///     Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns><c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(byte[]);
        }

        /// <summary>
        ///     Reads the json.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns>System.Object.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var encodedValue = reader.Value.ToString();
            return Encoding.ASCII.GetBytes(encodedValue);
        }

        /// <summary>
        ///     Writes the json.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var decodedValue = Encoding.ASCII.GetChars((byte[]) value).ToString();
            serializer.Serialize(writer, decodedValue);
        }
    }
}