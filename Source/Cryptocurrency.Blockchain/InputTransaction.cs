using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents an input transaction.
    /// </summary>
    public class InputTransaction
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="InputTransaction"/> class from being created.
        /// </summary>
        private InputTransaction()
        {
        }

        /// <summary>
        ///     Gets the previous output. Null for coinbase input.
        /// </summary>
        [JsonProperty("prev_out")]
        public OutputTransaction PreviousOutput { get; private set; }

        /// <summary>
        ///     Gets the script signature.
        /// </summary>
        [JsonProperty("script", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Script { get; private set; }

        /// <summary>
        ///     Gets the sequence.
        /// </summary>
        [JsonProperty("sequence", Required = Required.Always)]
        public long Sequence { get; private set; }
    }
}