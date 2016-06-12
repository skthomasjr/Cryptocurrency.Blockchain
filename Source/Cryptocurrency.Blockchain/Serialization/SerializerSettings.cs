using Newtonsoft.Json;
using System.Collections.Generic;
using Cryptocurrency.Serialization.Converters;

namespace Cryptocurrency.Blockchain.Serialization
{
    public class SerializerSettings : JsonSerializerSettings
    {
        public SerializerSettings()
        {
            Converters = new List<JsonConverter> {
                //new ByteArrayConverter(),
                //new DateTimeConverter(),
                new HexStringConverter(),
                new Nonce32RangeConverter(),
                //new NullableDateTimeConverter(),
                //new TimeSpanConverter()
            };
            ContractResolver = new ContractResolver();
            Error += (sender, e) =>
            {
                e.ErrorContext.Handled = true;
            };
        }
    }
}