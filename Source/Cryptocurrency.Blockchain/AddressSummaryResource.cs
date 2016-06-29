using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the REST resource for address summaries.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    [Route("/multiaddr?active={Address}", node: "addresses")]
    [Route("/multiaddr?active={Addresses}", node: "addresses")]
    public class AddressSummaryResource : Resource<AddressSummary>
    {
    }
}