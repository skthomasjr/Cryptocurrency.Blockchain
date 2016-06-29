using System.Linq;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     The REST client for accessing data on blockchain blocks and transactions.
    /// </summary>
    public interface IBlockchainDataClient
    {
        /// <summary>
        ///     Gets the REST resource for addresses.
        /// </summary>
        /// <value>The addresses.</value>
        IQueryable<Address> Addresses { get; }

        /// <summary>
        ///     Gets the REST resource for blockchain blocks.
        /// </summary>
        /// <value>The raw blocks.</value>
        IQueryable<Block> Blocks { get; }

        /// <summary>
        ///     Gets the REST resource for inventory data.
        /// </summary>
        /// <value>The inventory data.</value>
        IQueryable<InventoryData> InventoryData { get; }

        /// <summary>
        ///     Gets the REST resource for the latest blockchain block.
        /// </summary>
        /// <value>The latest blocks.</value>
        IQueryable<LatestBlock> LatestBlocks { get; }

        /// <summary>
        ///     Gets the REST resource for mined blocks.
        /// </summary>
        /// <value>The mined blocks.</value>
        IQueryable<MinedBlock> MinedBlocks { get; }

        /// <summary>
        ///     Gets the REST resource for multiple addresses.
        /// </summary>
        /// <value>The addresses.</value>
        IQueryable<AddressSummary> MultipleAddresses { get; }

        /// <summary>
        ///     Gets the REST resource for blockchain transactions.
        /// </summary>
        /// <value>The transactions.</value>
        IQueryable<Transaction> Transactions { get; }

        /// <summary>
        ///     Gets the REST resource for unspent outputs.
        /// </summary>
        /// <value>The unspent outputs.</value>
        IQueryable<UnspentOutput> UnspentOutputs { get; }
    }
}