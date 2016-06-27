using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents unconfirmed transactions.
    /// </summary>
    public class UnconfirmedTransactions
    {
        /// <summary>
        ///     Gets the transactions.
        /// </summary>
        /// <value>The transactions.</value>
        [JsonProperty("txs")]
        public IEnumerable<Transaction> Transactions { get; private set; }
    }
}