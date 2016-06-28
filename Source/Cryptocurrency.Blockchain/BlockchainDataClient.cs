using System.ComponentModel;
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
        [Route("/rawaddr/{Base58}", "limit={Limit}", "offset={Offset}")]
        [Route("/rawaddr/{Hash160}", "limit={Limit}", "offset={Offset}")]
        public Resource<Address> Addresses { get; private set; }

        /// <summary>
        ///     Gets the resource representing blocks at a given height.
        /// </summary>
        /// <value>The height of the blocks at.</value>
        [Route("/block-height/{Height}?format=json", node: "blocks")]
        public Resource<RawBlock> Blocks { get; private set; }

        /// <summary>
        ///     Gets the inventory data.
        /// </summary>
        /// <value>The inventory data.</value>
        [Route("/inv/{Hash}?format=json")]
        public Resource<InventoryData> InventoryData { get; private set; }

        /// <summary>
        ///     Gets the resource representing the latest blocks.
        /// </summary>
        /// <value>The latest blocks.</value>
        [Route("/latestblock")]
        public Resource<LatestBlock> LatestBlocks { get; private set; }

        /// <summary>
        ///     Gets the resource representing mined blocks.
        /// </summary>
        /// <value>The mined blocks.</value>
        [Route("/blocks/{DayInUnixTimeMilliseconds}?format=json", node: "blocks")]
        [Route("/blocks/{MiningPool}?format=json", node: "blocks")]
        public Resource<MinedBlock> MinedBlocks { get; private set; }

        /// <summary>
        ///     Gets the resource representing multiple addresses.
        /// </summary>
        /// <value>The multi addresses.</value>
        [Route("/multiaddr?active={Addresses}", node: "addresses")]
        public Resource<AddressSummary> MultiAddresses { get; private set; }

        /// <summary>
        ///     Gets the resource representing raw blockchain blocks.
        /// </summary>
        /// <value>The raw blocks.</value>
        [Route("/rawblock/{Index}")]
        [Route("/rawblock/{Hash}")]
        public Resource<RawBlock> RawBlocks { get; private set; }

        /// <summary>
        ///     Gets the resource representing blockchain transactions.
        /// </summary>
        /// <value>The transactions.</value>
        [Route("/rawtx/{Index}")]
        [Route("/rawtx/{Hash}")]
        public Resource<Transaction> Transactions { get; private set; }

        /// <summary>
        ///     Gets the resource representing unconfirmed transactions.
        /// </summary>
        /// <value>The unconfirmed transactions.</value>
        [Route("/unconfirmed-transactions?format=json", node: "txs")]
        public Resource<Transaction> UnconfirmedTransactions { get; private set; }

        /// <summary>
        ///     Gets the resource representing unspent outputs.
        /// </summary>
        /// <value>The unspent outputs.</value>
        [Route("/unspent?active={Address}", node: "unspent_outputs")]
        [Route("/unspent?active={Addresses}", node: "unspent_outputs")]
        public Resource<UnspentOutput> UnspentOutputs { get; private set; }

        //MultipleAddresses
    }
}