using System.Collections.Generic;
using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents an address.
    /// </summary>
    public class Address
    {
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
        ///     Gets the Hash160 representation of the address.
        /// </summary>
        /// <value>The hash160.</value>
        [JsonProperty("hash160", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Hash160 { get; private set; }

        /// <summary>
        ///     Gets the limit. Used as the resource criteria. Value is never set.
        /// </summary>
        /// <value>The limit.</value>
        public int Limit { get; }

        /// <summary>
        ///     Gets the offset. Used as the resource criteria. Value is never set.
        /// </summary>
        /// <value>The offset.</value>
        public int Offset { get; }

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

        /// <summary>
        ///     Gets the transactions.
        /// </summary>
        /// <value>The transactions.</value>
        [JsonProperty("txs", Required = Required.Always)]
        public IEnumerable<Transaction> Transactions { get; private set; }
    }
}