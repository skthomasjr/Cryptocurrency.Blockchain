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
        /// <value>The addresses.</value>
        [Routes("/rawaddr/{Base58}", "/rawaddr/{Hash160}")]
        [Parameters("limit={Limit}", "offset={Offset}")]
        public Resource<Address> Addresses { get; private set; }

        /// <summary>
        ///     Gets the resource representing blocks at a given height.
        /// </summary>
        /// <value>The height of the blocks at.</value>
        [Routes("/block-height/{Height}?format=json")]
        public Resource<BlockHeight> BlockHeight { get; private set; }

        /// <summary>
        ///     Gets the inventory data.
        /// </summary>
        /// <value>The inventory data.</value>
        [Route("/inv/{HashString}?format=json")]
        public Resource<InventoryData> InventoryData { get; private set; }

        /// <summary>
        ///     Gets the resource representing the latest blocks.
        /// </summary>
        /// <value>The latest blocks.</value>
        [Route("/latestblock")]
        public Resource<LatestBlock> LatestBlocks { get; private set; }

        /// <summary>
        ///     Gets the resource representing raw blockchain blocks.
        /// </summary>
        /// <value>The raw blocks.</value>
        [Routes("/rawblock/{Index}", "/rawblock/{Hash}")]
        public Resource<RawBlock> RawBlocks { get; private set; }

        /// <summary>
        ///     Gets the resource representing blockchain transactions.
        /// </summary>
        /// <value>The transactions.</value>
        [Routes("/rawtx/{Index}", "/rawtx/{Hash}")]
        public Resource<Transaction> Transactions { get; private set; }

        /// <summary>
        ///     Gets the unconfirmed transactions.
        /// </summary>
        /// <value>The unconfirmed transactions.</value>
        [Routes("/unconfirmed-transactions?format=json")]
        public Resource<UnconfirmedTransactions> UnconfirmedTransactions { get; private set; }

        ///// <summary>
        /////     Gets the unspent outputs.
        ///// </summary>
        ///// <value>The unspent outputs.</value>
        //[Routes("/unspent?active={Address}", "/unspent?active={Addresses}")]
        //public Resource<IEnumerable<UnspentOutput>, UnspentOutput> UnspentOutputs { get; private set; }
        //UnspentOutputs, MultipleAddresses, Blocks
    }
}