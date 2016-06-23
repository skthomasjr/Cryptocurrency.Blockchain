using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     The REST client for accessing data on blockchain blocks and transactions.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    public class BlockchainDataClient : RestClient
    {
        /// <summary>
        ///     Gets the resource representing raw blockchain blocks.
        /// </summary>
        /// <value>The raw blocks.</value>
        //[Route("/rawblock/{Hash}")]
        [Route("/rawblock/{BlockIndex}")]
        public Resource<RawBlock> RawBlocks { get; private set; }
    }
}