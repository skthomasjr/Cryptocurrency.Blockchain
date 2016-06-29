using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the REST resource for addresses.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    [Route("/rawaddr/{Base58}", "limit={Limit}", "offset={Offset}")]
    [Route("/rawaddr/{Hash160}", "limit={Limit}", "offset={Offset}")]
    public class AddressResource : Resource<Address>
    {
    }
}