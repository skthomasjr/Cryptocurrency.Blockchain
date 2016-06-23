using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Class OutputTransaction.
    /// </summary>
    public class OutputTransaction
    {
        /// <summary>
        ///     Prevents a default instance of the <see cref="OutputTransaction" /> class from being created.
        /// </summary>
        private OutputTransaction()
        {
        }

        /// <summary>
        ///     Gets the wallet address.
        /// </summary>
        [JsonProperty("addr")]
        public string Address { get; private set; }

        /// <summary>
        ///     Gets the output index in the transaction.
        /// </summary>
        [JsonProperty("n", Required = Required.Always)]
        public int Index { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether output is spent.
        /// </summary>
        [JsonProperty("spent", Required = Required.Always)]
        public bool IsSpent { get; private set; }

        /// <summary>
        ///     Gets the script signature.
        /// </summary>
        [JsonProperty("script", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Script { get; private set; }

        /// <summary>
        ///     Gets the index of the transaction.
        /// </summary>
        [JsonProperty("tx_index", Required = Required.Always)]
        public long TransactionIndex { get; private set; }

        /// <summary>
        ///     Gets the value.
        /// </summary>
        [JsonProperty("value", Required = Required.Always)]
        public decimal Value { get; private set; }
    }
}