using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents an address summary.
    /// </summary>
    public class AddressSummary
    {
        /// <summary>
        ///     Gets the addresses. Used as the resource criteria. Value is never set.
        /// </summary>
        /// <value>The addresses.</value>
        public string Addresses { get; }

        /// <summary>
        ///     Gets the final balance.
        /// </summary>
        /// <value>The balance.</value>
        [JsonProperty("final_balance", Required = Required.Always)]
        [JsonConverter(typeof(SatoshiValueJsonConverter))]
        public decimal Balance { get; private set; }

        /// <summary>
        ///     Gets the BASE58 representation of the address.
        /// </summary>
        /// <value>The base58.</value>
        [JsonProperty("address", Required = Required.Always)]
        public string Base58 { get; private set; }

        /// <summary>
        ///     Gets the total amount received.
        /// </summary>
        /// <value>The received.</value>
        [JsonProperty("total_received", Required = Required.Always)]
        [JsonConverter(typeof(SatoshiValueJsonConverter))]
        public decimal Received { get; private set; }

        /// <summary>
        ///     Gets the total amount sent.
        /// </summary>
        /// <value>The sent.</value>
        [JsonProperty("total_sent", Required = Required.Always)]
        [JsonConverter(typeof(SatoshiValueJsonConverter))]
        public decimal Sent { get; private set; }

        /// <summary>
        ///     Gets the total count of all transactions.
        /// </summary>
        /// <value>The transaction count.</value>
        [JsonProperty("n_tx", Required = Required.Always)]
        public long TransactionCount { get; private set; }
    }
}