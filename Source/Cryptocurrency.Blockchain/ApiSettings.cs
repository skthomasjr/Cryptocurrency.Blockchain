namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Class ApiSettings.
    /// </summary>
    public class ApiSettings
    {
        /// <summary>
        ///     Gets or sets the raw block URI template.
        /// </summary>
        /// <value>The raw block URI template.</value>
        public string RawBlockUriTemplate { get; set; } = "https://blockchain.info/rawblock/{BlockIndex}";
    }
}