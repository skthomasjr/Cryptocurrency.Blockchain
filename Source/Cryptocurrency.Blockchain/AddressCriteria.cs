namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Additional criteria for accessing Addresses.
    /// </summary>
    public class AddressCriteria
    {
        /// <summary>
        ///     Gets the limit.
        /// </summary>
        /// <value>The limit.</value>
        public int Limit { get; }

        /// <summary>
        ///     Gets the offset.
        /// </summary>
        /// <value>The offset.</value>
        public int Offset { get; }
    }
}