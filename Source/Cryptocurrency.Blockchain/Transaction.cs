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
    public class Transaction
    {
        /// <summary>
        ///     Prevents a default instance of the <see cref="Transaction" /> class from being created.
        /// </summary>
        private Transaction()
        {
        }

        /// <summary>
        ///     Gets the block height. Null for unconfirmed transactions.
        /// </summary>
        [JsonProperty("block_height")]
        public long? BlockHeight { get; private set; }

        /// <summary>
        ///     Gets the block hash.
        /// </summary>
        [JsonProperty("hash", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Hash { get; private set; }

        /// <summary>
        ///     Gets the transaction index.
        /// </summary>
        [JsonProperty("tx_index", Required = Required.Always)]
        public long Index { get; private set; }

        /// <summary>
        ///     Gets the inputs.
        /// </summary>
        [JsonProperty("inputs", Required = Required.Always)]
        public IEnumerable<InputTransaction> Inputs { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether this block has been double spent.
        /// </summary>
        [JsonProperty("double_spend")]
        public bool IsDoubleSpent { get; private set; }

        /// <summary>
        ///     Gets the outputs.
        /// </summary>
        [JsonProperty("out", Required = Required.Always)]
        public IEnumerable<OutputTransaction> Outputs { get; private set; }

        /// <summary>
        ///     Gets the IP address that relayed the block.
        /// </summary>
        [JsonProperty("relayed_by", Required = Required.Always)]
        [JsonConverter(typeof(IpAddressConverter))]
        public IPAddress RelayedBy { get; private set; }

        /// <summary>
        ///     Gets the serialized size.
        /// </summary>
        [JsonProperty("size", Required = Required.Always)]
        public long Size { get; private set; }

        /// <summary>
        ///     Gets the transaction time.
        /// </summary>
        [JsonProperty("time", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        public DateTime Time { get; private set; }

        /// <summary>
        ///     Gets the version as specified by the protocol.
        /// </summary>
        [JsonProperty("ver", Required = Required.Always)]
        public int Version { get; private set; }
    }
}