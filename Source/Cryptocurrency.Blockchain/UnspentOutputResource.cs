using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the REST resource for unspent outputs.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    [Route("/unspent?active={Address}", node: "unspent_outputs")]
    [Route("/unspent?active={Addresses}", node: "unspent_outputs")]
    public class UnspentOutputResource : Resource<UnspentOutput>
    {
    }
}