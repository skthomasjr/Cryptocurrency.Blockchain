using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the REST resource for mined blocks.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    [Route("/blocks/{DayInUnixTimeMilliseconds}?format=json", node: "blocks")]
    [Route("/blocks/{MiningPool}?format=json", node: "blocks")]
    public class MinedBlockResource : Resource<MinedBlock>
    {
    }
}