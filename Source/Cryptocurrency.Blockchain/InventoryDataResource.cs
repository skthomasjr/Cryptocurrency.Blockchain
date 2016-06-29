using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the REST resource for inventory data.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    [Route("/inv/{Hash}?format=json")]
    public class InventoryDataResource : Resource<InventoryData>
    {
    }
}