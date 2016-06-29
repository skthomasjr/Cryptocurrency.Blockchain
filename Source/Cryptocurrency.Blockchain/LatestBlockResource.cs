using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the REST resource for the latest blockchain block.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    [Route("/latestblock")]
    public class LatestBlockResource : Resource<LatestBlock>
    {
    }
}