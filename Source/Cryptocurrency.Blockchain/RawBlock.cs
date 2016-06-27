using System;
using System.Collections.Generic;
using System.Net;
using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents a raw blockchain block.
    /// </summary>
    public class RawBlock
    {
        /// <summary>
        ///     Gets the difficulty target.
        /// </summary>
        /// <value>The bits.</value>
        [JsonProperty("bits", Required = Required.Always)]
        public long Bits { get; private set; }

        /// <summary>
        ///     Gets the total transaction fee.
        /// </summary>
        /// <value>The fee.</value>
        [JsonProperty("fee", Required = Required.Always)]
        [JsonConverter(typeof(SatoshiValueJsonConverter))]
        public decimal Fee { get; private set; }

        /// <summary>
        ///     Gets the block hash.
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
        ///     Gets a value indicating whether this block is on the main chain.
        /// </summary>
        /// <value><c>true</c> if this instance is main chain; otherwise, <c>false</c>.</value>
        [JsonProperty("main_chain")]
        public bool IsMainChain { get; private set; }

        /// <summary>
        ///     Gets the merkle root.
        /// </summary>
        /// <value>The merkle root.</value>
        [JsonProperty("mrkl_root", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex MerkleRoot { get; private set; }

        /// <summary>
        ///     Gets the nonce.
        /// </summary>
        /// <value>The nonce.</value>
        [JsonProperty("nonce", Required = Required.Always)]
        public long Nonce { get; private set; }

        /// <summary>
        ///     Gets the previous block.
        /// </summary>
        /// <value>The previous block.</value>
        [JsonProperty("prev_block", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex PreviousBlock { get; private set; }

        /// <summary>
        ///     Gets the IP address that relayed the block.
        /// </summary>
        /// <value>The relayed by.</value>
        [JsonProperty("relayed_by")]
        [JsonConverter(typeof(IpAddressConverter))]
        public IPAddress RelayedBy { get; private set; }

        /// <summary>
        ///     Gets the serialized size.
        /// </summary>
        /// <value>The size.</value>
        [JsonProperty("size", Required = Required.Always)]
        public long Size { get; private set; }

        /// <summary>
        ///     Gets the block time set by the miner.
        /// </summary>
        /// <value>The time.</value>
        [JsonProperty("time", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeSecondsJsonConverter))]
        public DateTime Time { get; private set; }

        /// <summary>
        ///     Gets the transaction count.
        /// </summary>
        /// <value>The transaction count.</value>
        [JsonProperty("n_tx")]
        public long TransactionCount { get; private set; }

        /// <summary>
        ///     Gets the transactions.
        /// </summary>
        /// <value>The transactions.</value>
        [JsonProperty("tx", Required = Required.Always)]
        public IEnumerable<RawBlockTransaction> Transactions { get; private set; }

        /// <summary>
        ///     Gets the version as specified by the protocol.
        /// </summary>
        /// <value>The version.</value>
        [JsonProperty("ver", Required = Required.Always)]
        public int Version { get; private set; }
    }
}