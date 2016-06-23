namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Class InputTransaction.
    /// </summary>
    public class InputTransaction
    {
        /// <summary>
        ///     Gets or sets the previous output.
        /// </summary>
        /// <value>The previous output.</value>
        public OutputTransaction PreviousOutput { get; set; }

        /// <summary>
        ///     Gets or sets the script.
        /// </summary>
        /// <value>The script.</value>
        public string Script { get; set; }

        /// <summary>
        ///     Gets or sets the sequence.
        /// </summary>
        /// <value>The sequence.</value>
        public long Sequence { get; set; }
    }
}