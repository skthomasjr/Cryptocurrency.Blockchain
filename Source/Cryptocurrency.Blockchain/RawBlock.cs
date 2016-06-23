using System;
using System.Collections.Generic;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Class RawBlock.
    /// </summary>
    public class RawBlock
    {
        /// <summary>
        ///     Gets or sets the bits.
        /// </summary>
        /// <value>The bits.</value>
        public int Bits { get; set; }

        /// <summary>
        ///     Gets or sets the index of the block.
        /// </summary>
        /// <value>The index of the block.</value>
        public long BlockIndex { get; set; }

        /// <summary>
        ///     Gets or sets the fee.
        /// </summary>
        /// <value>The fee.</value>
        public long Fee { get; set; }

        /// <summary>
        ///     Gets or sets the hash.
        /// </summary>
        /// <value>The hash.</value>
        public Hex Hash { get; set; }

        /// <summary>
        ///     Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public int Height { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is main chain.
        /// </summary>
        /// <value><c>true</c> if this instance is main chain; otherwise, <c>false</c>.</value>
        public bool IsMainChain { get; set; }

        /// <summary>
        ///     Gets or sets the merkle root.
        /// </summary>
        /// <value>The merkle root.</value>
        public Hex MerkleRoot { get; set; }

        /// <summary>
        ///     Gets or sets the nonce.
        /// </summary>
        /// <value>The nonce.</value>
        public long Nonce { get; set; }

        /// <summary>
        ///     Gets or sets the previous block.
        /// </summary>
        /// <value>The previous block.</value>
        public Hex PreviousBlock { get; set; }

        /// <summary>
        ///     Gets or sets the relayed by.
        /// </summary>
        /// <value>The relayed by.</value>
        public string RelayedBy { get; set; }

        /// <summary>
        ///     Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        public int Size { get; set; }

        /// <summary>
        ///     Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        public DateTime Time { get; set; }

        /// <summary>
        ///     Gets or sets the transaction count.
        /// </summary>
        /// <value>The transaction count.</value>
        public int TransactionCount { get; set; }

        /// <summary>
        ///     Gets or sets the transactions.
        /// </summary>
        /// <value>The transactions.</value>
        public IEnumerable<Transaction> Transactions { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        public int Version { get; set; }
    }
}