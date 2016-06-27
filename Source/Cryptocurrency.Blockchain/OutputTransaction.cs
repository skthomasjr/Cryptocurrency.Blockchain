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
        ///     Gets the wallet address.
        /// </summary>
        /// <value>The address.</value>
        [JsonProperty("addr")]
        public string Address { get; private set; }

        /// <summary>
        ///     Gets the output index in the transaction.
        /// </summary>
        /// <value>The index.</value>
        [JsonProperty("n", Required = Required.Always)]
        public int Index { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether output is spent.
        /// </summary>
        /// <value><c>true</c> if this instance is spent; otherwise, <c>false</c>.</value>
        [JsonProperty("spent", Required = Required.Always)]
        public bool IsSpent { get; private set; }

        /// <summary>
        ///     Gets the script signature.
        /// </summary>
        /// <value>The script.</value>
        [JsonProperty("script", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Script { get; private set; }

        /// <summary>
        ///     Gets the index of the transaction.
        /// </summary>
        /// <value>The index of the transaction.</value>
        [JsonProperty("tx_index", Required = Required.Always)]
        public long TransactionIndex { get; private set; }

        /// <summary>
        ///     Gets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("value", Required = Required.Always)]
        [JsonConverter(typeof(SatoshiValueJsonConverter))]
        public decimal Value { get; private set; }
    }
}