using System;
using System.Net;
using Cryptocurrency.Blockchain.Serialization.Converters;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents inventory data.
    /// </summary>
    public class InventoryData
    {
        /// <summary>
        ///     Gets the number of nodes currently connected.
        /// </summary>
        /// <value>The n connected.</value>
        [JsonProperty("nconnected", Required = Required.Always)]
        public int ConnectedNodeCount { get; private set; }

        /// <summary>
        ///     Gets the hash.
        /// </summary>
        /// <value>The hash.</value>
        [JsonProperty("hash", Required = Required.Always)]
        [JsonConverter(typeof(HexJsonConverter))]
        public Hex Hash { get; private set; }

        /// <summary>
        ///     Gets the hash string. Used as the resource criteria. Value is never set.
        /// </summary>
        /// <value>The hash string.</value>
        public string HashString { get; }

        /// <summary>
        ///     Gets the initial IP address of the peer requesting inventory data.
        /// </summary>
        /// <value>The initial ip.</value>
        [JsonProperty("initial_ip", Required = Required.Always)]
        [JsonConverter(typeof(IpAddressConverter))]
        public IPAddress InitialIp { get; private set; }

        /// <summary>
        ///     Gets the initial time a peer requested inventory data.
        /// </summary>
        /// <value>The initial time.</value>
        [JsonProperty("initial_time", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeMillisecondsJsonConverter))]
        public DateTime InitialTime { get; private set; }

        /// <summary>
        ///     Gets the last time inventory data was requested.
        /// </summary>
        /// <value>The last time.</value>
        [JsonProperty("last_time", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeMillisecondsJsonConverter))]
        public DateTime LastTime { get; private set; }

        /// <summary>
        ///     Gets the number of nodes who received this hash.
        /// </summary>
        /// <value>The relayed count.</value>
        [JsonProperty("relayed_count", Required = Required.Always)]
        public int RelayedCount { get; private set; }

        /// <summary>
        ///     Gets the ratio of total connected nodes to the relayed count.
        /// </summary>
        /// <value>The relayed percent.</value>
        [JsonProperty("relayed_percent", Required = Required.Always)]
        public int RelayedPercent { get; private set; }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; private set; }
    }
}