using System;
using System.Collections.Generic;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Class Transaction.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        ///     Gets or sets the hash.
        /// </summary>
        /// <value>The hash.</value>
        public Hex Hash { get; set; }

        /// <summary>
        ///     Gets or sets the inputs.
        /// </summary>
        /// <value>The inputs.</value>
        public IEnumerable<InputTransaction> Inputs { get; set; }

        /// <summary>
        ///     Gets or sets the lock time.
        /// </summary>
        /// <value>The lock time.</value>
        public DateTime? LockTime { get; set; }

        /// <summary>
        ///     Gets or sets the outputs.
        /// </summary>
        /// <value>The outputs.</value>
        public IEnumerable<OutputTransaction> Outputs { get; set; }

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
        ///     Gets or sets the index of the transaction.
        /// </summary>
        /// <value>The index of the transaction.</value>
        public long TransactionIndex { get; set; }

        /// <summary>
        ///     Gets or sets the size of the vector input.
        /// </summary>
        /// <value>The size of the vector input.</value>
        public int VectorInputSize { get; set; }

        /// <summary>
        ///     Gets or sets the size of the vector output.
        /// </summary>
        /// <value>The size of the vector output.</value>
        public int VectorOutputSize { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        public int Version { get; set; }
    }
}