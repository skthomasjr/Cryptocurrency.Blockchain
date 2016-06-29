using NetClient.Rest;

namespace Cryptocurrency.Blockchain
{
    /// <summary>
    ///     Represents the REST resource for blockchain transactions.
    /// </summary>
    [BaseUri("https://blockchain.info")]
    [Route("/rawtx/{Hash}", "scripts={IncludeScripts}")]
    [Route("/rawtx/{Index}", "scripts={IncludeScripts}")]
    [Route("/unconfirmed-transactions?format=json", node: "txs")]
    public class TransactionResource : Resource<Transaction>
    {
    }
}