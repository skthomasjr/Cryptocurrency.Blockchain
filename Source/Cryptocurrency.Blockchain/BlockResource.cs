using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the REST resource for blockchain blocks.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    [Route("/rawblock/{Index}")]
    [Route("/rawblock/{Hash}")]
    [Route("/block-height/{Height}?format=json", node: "blocks")]
    public class BlockResource : Resource<Block>
    {
    }
}