using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents blocks at a given height.
    /// </summary>
    public class BlockHeight
    {
        /// <summary>
        ///     Gets the blocks.
        /// </summary>
        /// <value>The blocks.</value>
        [JsonProperty("blocks")]
        public IEnumerable<RawBlock> Blocks { get; private set; }

        /// <summary>
        ///     Gets the height. Used as the resource criteria. Value is never set.
        /// </summary>
        /// <value>The height.</value>
        public long Height { get; }
    }
}