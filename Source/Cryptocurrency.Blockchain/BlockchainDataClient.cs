﻿using System.Linq;
using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     The REST client for accessing data on blockchain blocks and transactions.
    /// </summary>
    public class BlockchainDataClient : RestClient, IBlockchainDataClient
    {
        /// <summary>
        ///     Gets the REST resource for addresses.
        /// </summary>
        /// <value>The addresses.</value>
        public IQueryable<Address> Addresses { get; } = new AddressResource();

        /// <summary>
        ///     Gets the REST resource for blockchain blocks.
        /// </summary>
        /// <value>The raw blocks.</value>
        public IQueryable<Block> Blocks { get; } = new BlockResource();

        /// <summary>
        ///     Gets the REST resource for inventory data.
        /// </summary>
        /// <value>The inventory data.</value>
        public IQueryable<InventoryData> InventoryData { get; } = new InventoryDataResource();

        /// <summary>
        ///     Gets the REST resource for the latest blockchain block.
        /// </summary>
        /// <value>The latest blocks.</value>
        public IQueryable<LatestBlock> LatestBlocks { get; } = new LatestBlockResource();

        /// <summary>
        ///     Gets the REST resource for mined blocks.
        /// </summary>
        /// <value>The mined blocks.</value>
        public IQueryable<MinedBlock> MinedBlocks { get; } = new MinedBlockResource();

        /// <summary>
        ///     Gets the REST resource for multiple addresses.
        /// </summary>
        /// <value>The addresses.</value>
        public IQueryable<AddressSummary> MultipleAddresses { get; } = new AddressSummaryResource();

        /// <summary>
        ///     Gets the REST resource for blockchain transactions.
        /// </summary>
        /// <value>The transactions.</value>
        public IQueryable<Transaction> Transactions { get; } = new TransactionResource();

        /// <summary>
        ///     Gets the REST resource for unspent outputs.
        /// </summary>
        /// <value>The unspent outputs.</value>
        public IQueryable<UnspentOutput> UnspentOutputs { get; } = new UnspentOutputResource();
    }
}