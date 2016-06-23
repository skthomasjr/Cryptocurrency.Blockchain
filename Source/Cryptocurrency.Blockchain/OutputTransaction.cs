namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Class OutputTransaction.
    /// </summary>
    public class OutputTransaction
    {
        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the index.
        /// </summary>
        /// <value>The index.</value>
        public int Index { get; set; }

        /// <summary>
        ///     Gets or sets the script.
        /// </summary>
        /// <value>The script.</value>
        public string Script { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="OutputTransaction" /> is spent.
        /// </summary>
        /// <value><c>true</c> if spent; otherwise, <c>false</c>.</value>
        public bool Spent { get; set; }

        /// <summary>
        ///     Gets or sets the index of the transaction.
        /// </summary>
        /// <value>The index of the transaction.</value>
        public long TransactionIndex { get; set; }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public int Type { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public long Value { get; set; }
    }
}