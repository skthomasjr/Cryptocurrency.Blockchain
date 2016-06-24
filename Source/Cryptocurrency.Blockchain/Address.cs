using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents an address.
    /// </summary>
    public class Address
    {
        /// <summary>
        ///     Prevents a default instance of the <see cref="Address" /> class from being created.
        /// </summary>
        private Address()
        {
        }

        /// <summary>
        ///     Gets the final balance.
        /// </summary>
        [JsonProperty("final_balance", Required = Required.Always)]
        public decimal Balance { get; private set; }

        /// <summary>
        ///     Gets the BASE58 representation of the address.
        /// </summary>
        [JsonProperty("address", Required = Required.Always)]
        public string Base58 { get; private set; }

        /// <summary>
        ///     Gets the Hash160 representation of the address.
        /// </summary>
        [JsonProperty("hash160", Required = Required.Always)]
        public string Hash160 { get; private set; }

        /// <summary>
        ///     Gets the total amount received.
        /// </summary>
        [JsonProperty("total_received", Required = Required.Always)]
        public decimal Received { get; private set; }

        /// <summary>
        ///     Gets the total amount sent.
        /// </summary>
        [JsonProperty("total_sent", Required = Required.Always)]
        public decimal Sent { get; private set; }

        /// <summary>
        ///     Gets the total count of all transactions.
        /// </summary>
        [JsonProperty("n_tx", Required = Required.Always)]
        public long TransactionCount { get; private set; }

        /// <summary>
        ///     Gets the transactions.
        /// </summary>
        [JsonProperty("txs", Required = Required.Always)]
        public IEnumerable<Transaction> Transactions { get; private set; }
    }
}