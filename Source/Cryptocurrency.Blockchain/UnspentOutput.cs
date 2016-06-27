using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents an unspent output.
    /// </summary>
    public class UnspentOutput
    {
        ///// <summary>
        ///// Gets the addresses. Used as the resource criteria. Value is never set.
        ///// </summary>
        ///// <value>The addresses.</value>
        //public IEnumerable<string> Addresses { get; }

        /// <summary>
        ///     Gets the address. Used as the resource criteria. Value is never set.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; }

        /// <summary>
        ///     Gets the addresses. Used as the resource criteria. Value is never set.
        /// </summary>
        /// <value>The addresses.</value>
        public string Addresses { get; }

        /// <summary>
        ///     Gets the confirmations.
        /// </summary>
        /// <value>The confirmations.</value>
        [JsonProperty("confirmations", Required = Required.Always)]
        public long Confirmations { get; private set; }

        /// <summary>
        ///     Gets the script.
        /// </summary>
        /// <value>The script.</value>
        [JsonProperty("script", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Script { get; private set; }

        /// <summary>
        ///     Gets the transaction hash.
        /// </summary>
        /// <value>The transaction hash.</value>
        [JsonProperty("tx_hash", Required = Required.Always)]
        public string TransactionHash { get; private set; }

        /// <summary>
        ///     Gets the index of the transaction.
        /// </summary>
        /// <value>The index of the transaction.</value>
        [JsonProperty("tx_index", Required = Required.Always)]
        public long TransactionIndex { get; private set; }

        /// <summary>
        ///     Gets the index of the transaction output.
        /// </summary>
        /// <value>The index of the transaction output.</value>
        [JsonProperty("tx_output_n", Required = Required.Always)]
        public int TransactionOutputIndex { get; private set; }

        /// <summary>
        ///     Gets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("value", Required = Required.Always)]
        [JsonConverter(typeof(SatoshiValueJsonConverter))]
        public decimal Value { get; private set; }
    }
}