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
        ///     Prevents a default instance of the <see cref="RawBlock" /> class from being created.
        /// </summary>
        private RawBlock()
        {
        }

        /// <summary>
        ///     Gets the difficulty target.
        /// </summary>
        [JsonProperty("bits", Required = Required.Always)]
        public long Bits { get; private set; }

        /// <summary>
        ///     Gets the block index.
        /// </summary>
        [JsonProperty("block_index", Required = Required.Always)]
        public long BlockIndex { get; private set; }

        /// <summary>
        ///     Gets the total transaction fee.
        /// </summary>
        [JsonProperty("fee", Required = Required.Always)]
        public decimal Fee { get; private set; }

        /// <summary>
        ///     Gets the block hash.
        /// </summary>
        [JsonProperty("hash", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Hash { get; private set; }

        /// <summary>
        ///     Gets the block height.
        /// </summary>
        [JsonProperty("height", Required = Required.Always)]
        public long Height { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether this block is on the main chain.
        /// </summary>
        [JsonProperty("main_chain")]
        public bool IsMainChain { get; private set; }

        /// <summary>
        ///     Gets the merkle root.
        /// </summary>
        [JsonProperty("mrkl_root", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex MerkleRoot { get; private set; }

        /// <summary>
        ///     Gets the nonce.
        /// </summary>
        [JsonProperty("nonce", Required = Required.Always)]
        public long Nonce { get; private set; }

        /// <summary>
        ///     Gets the previous block.
        /// </summary>
        [JsonProperty("prev_block", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex PreviousBlock { get; private set; }

        /// <summary>
        ///     Gets the IP address that relayed the block.
        /// </summary>
        [JsonProperty("relayed_by")]
        [JsonConverter(typeof(IpAddressConverter))]
        public IPAddress RelayedBy { get; private set; }

        /// <summary>
        ///     Gets the serialized size.
        /// </summary>
        [JsonProperty("size", Required = Required.Always)]
        public long Size { get; private set; }

        /// <summary>
        ///     Gets the block time set by the miner.
        /// </summary>
        [JsonProperty("time", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        public DateTime Time { get; private set; }

        /// <summary>
        ///     Gets the transactions.
        /// </summary>
        [JsonProperty("tx", Required = Required.Always)]
        public IEnumerable<Transaction> Transactions { get; private set; }

        /// <summary>
        ///     Gets the version as specified by the protocol.
        /// </summary>
        [JsonProperty("ver", Required = Required.Always)]
        public int Version { get; private set; }
    }
}