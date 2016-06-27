using System;
using System.Collections.Generic;
using System.Net;
using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents a blockchain transaction.
    /// </summary>
    public class RawBlockTransaction
    {
        /// <summary>
        ///     Gets the block height. Null for unconfirmed transactions.
        /// </summary>
        /// <value>The height of the block.</value>
        [JsonProperty("block_height")]
        public long? BlockHeight { get; private set; }

        /// <summary>
        ///     Gets the hash.
        /// </summary>
        /// <value>The hash.</value>
        [JsonProperty("hash", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Hash { get; private set; }

        /// <summary>
        ///     Gets the transaction index.
        /// </summary>
        /// <value>The index.</value>
        [JsonProperty("tx_index", Required = Required.Always)]
        public long Index { get; private set; }

        /// <summary>
        ///     Gets the inputs.
        /// </summary>
        /// <value>The inputs.</value>
        [JsonProperty("inputs", Required = Required.Always)]
        public IEnumerable<InputTransaction> Inputs { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether this block has been double spent.
        /// </summary>
        /// <value><c>true</c> if this instance is double spent; otherwise, <c>false</c>.</value>
        [JsonProperty("double_spend")]
        public bool IsDoubleSpent { get; private set; }

        /// <summary>
        ///     Gets the outputs.
        /// </summary>
        /// <value>The outputs.</value>
        [JsonProperty("out", Required = Required.Always)]
        public IEnumerable<OutputTransaction> Outputs { get; private set; }

        /// <summary>
        ///     Gets the IP address that relayed the block.
        /// </summary>
        /// <value>The relayed by.</value>
        [JsonProperty("relayed_by", Required = Required.Always)]
        [JsonConverter(typeof(IpAddressConverter))]
        public IPAddress RelayedBy { get; private set; }

        /// <summary>
        ///     Gets the serialized size.
        /// </summary>
        /// <value>The size.</value>
        [JsonProperty("size", Required = Required.Always)]
        public long Size { get; private set; }

        /// <summary>
        ///     Gets the transaction time.
        /// </summary>
        /// <value>The time.</value>
        [JsonProperty("time", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeSecondsJsonConverter))]
        public DateTime Time { get; private set; }

        /// <summary>
        ///     Gets the version as specified by the protocol.
        /// </summary>
        /// <value>The version.</value>
        [JsonProperty("ver", Required = Required.Always)]
        public int Version { get; private set; }
    }
}