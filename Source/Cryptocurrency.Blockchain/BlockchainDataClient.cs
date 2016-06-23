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
        ///     Gets the resource representing addresses.
        /// </summary>
        [Route("/address/{Hash160}", "/address/{Base58}", "/rawaddr/{Base58}")]
        public Resource<Address> Addresses { get; private set; }

        /// <summary>
        ///     Gets the resource representing raw blockchain blocks.
        /// </summary>
        [Route("/rawblock/{Index}", "/rawblock/{Hash}")]
        public Resource<RawBlock> RawBlocks { get; private set; }

        /// <summary>
        ///     Gets the resource representing blockchain transactions.
        /// </summary>
        [Route("/rawtx/{Index}", "/rawtx/{Hash}", "/tx-index/{Index}")]
        public Resource<Transaction> Transactions { get; private set; }
    }
}