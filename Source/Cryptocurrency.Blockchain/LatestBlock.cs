using System;
using System.Collections.Generic;
using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the latest block.  Response to "GetLatestBlock" method.
    /// </summary>
    public class LatestBlock
    {
        /// <summary>
        ///     Gets the hash.
        /// </summary>
        /// <value>The hash.</value>
        [JsonProperty("hash", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Hash { get; private set; }

        /// <summary>
        ///     Gets the block height.
        /// </summary>
        /// <value>The height.</value>
        [JsonProperty("height", Required = Required.Always)]
        public long Height { get; private set; }

        /// <summary>
        ///     Gets the block index.
        /// </summary>
        /// <value>The index.</value>
        [JsonProperty("block_index", Required = Required.Always)]
        public long Index { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether this transaction has been double spent.
        /// </summary>
        /// <value><c>true</c> if this instance is double spent; otherwise, <c>false</c>.</value>
        [JsonProperty("double_spend")]
        public bool IsDoubleSpent { get; private set; }

        /// <summary>
        ///     Gets the transaction time.
        /// </summary>
        /// <value>The time.</value>
        [JsonProperty("time", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        public DateTime Time { get; private set; }

        /// <summary>
        ///     Gets the indexes of transactions included in this block.
        /// </summary>
        /// <value>The transaction indexes.</value>
        [JsonProperty("txIndexes", Required = Required.Always)]
        public IEnumerable<long> TransactionIndexes { get; private set; }
    }
}