using System;
using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents a mined block.
    /// </summary>
    public class MinedBlock
    {
        /// <summary>
        ///     Gets the hash.
        /// </summary>
        /// <value>The hash.</value>
        [JsonProperty("hash", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Hash { get; private set; }

        /// <summary>
        ///     Gets the height.
        /// </summary>
        /// <value>The height.</value>
        [JsonProperty("height", Required = Required.Always)]
        public long Height { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether this instance is main chain.
        /// </summary>
        /// <value><c>true</c> if this instance is main chain; otherwise, <c>false</c>.</value>
        [JsonProperty("main_chain")]
        public bool IsMainChain { get; private set; }

        /// <summary>
        ///     Gets the block time set by the miner.
        /// </summary>
        /// <value>The time.</value>
        [JsonProperty("time", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeSecondsJsonConverter))]
        public DateTime Time { get; private set; }
    }
}