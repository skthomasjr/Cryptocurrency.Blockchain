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
        ///     Gets the previous output. Null for coinbase input.
        /// </summary>
        /// <value>The previous output.</value>
        [JsonProperty("prev_out")]
        public OutputTransaction PreviousOutput { get; private set; }

        /// <summary>
        ///     Gets the script signature.
        /// </summary>
        /// <value>The script.</value>
        [JsonProperty("script", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Script { get; private set; }

        /// <summary>
        ///     Gets the sequence.
        /// </summary>
        /// <value>The sequence.</value>
        [JsonProperty("sequence", Required = Required.Always)]
        public long Sequence { get; private set; }
    }
}