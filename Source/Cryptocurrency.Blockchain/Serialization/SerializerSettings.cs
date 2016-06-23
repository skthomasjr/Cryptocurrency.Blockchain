using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain.Serialization
{
    /// <summary>
    ///     Class SerializerSettings.
    /// </summary>
    public class SerializerSettings : JsonSerializerSettings
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SerializerSettings" /> class.
        /// </summary>
        public SerializerSettings()
        {
            Converters = new List<JsonConverter>();
            ContractResolver = new ContractResolver();
            Error += (sender, e) => { e.ErrorContext.Handled = true; };
        }
    }
}