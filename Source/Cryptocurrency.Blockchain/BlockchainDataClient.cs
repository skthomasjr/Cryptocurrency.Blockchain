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
        [Routes("/rawaddr/{Base58}", "/rawaddr/{Hash160}")]
        [Parameters("limit={Limit}", "offset={Offset}")]
        public Resource<Address, AddressCriteria> Addresses { get; private set; }

        /// <summary>
        ///     Gets the resource representing the latest blocks.
        /// </summary>
        [Route("/latestblock")]
        public Resource<LatestBlock> LatestBlocks { get; private set; }

        /// <summary>
        ///     Gets the resource representing raw blockchain blocks.
        /// </summary>
        [Routes("/rawblock/{Index}", "/rawblock/{Hash}")]
        public Resource<RawBlock> RawBlocks { get; private set; }

        /// <summary>
        ///     Gets the resource representing blockchain transactions.
        /// </summary>
        [Routes("/rawtx/{Index}", "/rawtx/{Hash}")]
        public Resource<Transaction> Transactions { get; private set; }
    }
}