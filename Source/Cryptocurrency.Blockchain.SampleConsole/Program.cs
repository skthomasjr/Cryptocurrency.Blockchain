using System;
using System.Linq;

namespace Cryptocurrency.Blockchain.SampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

            // Using LINQ method syntax.
            var address = client.Addresses
                .Where(a => a.Base58 == "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(address?.Base58);

            // Using LINQ query syntax.
            var latestBlocks = from r in client.LatestBlocks select r;
            var latestBlock = latestBlocks.ToArray().SingleOrDefault();
            Console.WriteLine(latestBlock?.Index);

            var rawBlocks = from r in client.RawBlocks where r.Index == 417260 select r;
            var rawBlock = rawBlocks.ToArray().SingleOrDefault();
            Console.WriteLine(rawBlock?.Index);

            var transactions = from t in client.Transactions where t.Index == 57048523 select t;
            var transaction = transactions.ToArray().SingleOrDefault();
            Console.WriteLine(transaction?.Index);

            var block = client.Blocks
                .Where(b => b.Height == 234003)
                .ToArray()
                .FirstOrDefault();
            Console.WriteLine(block?.Hash);

            var unconfirmedTransactions = client.UnconfirmedTransactions
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(unconfirmedTransactions?.Transactions.Count());

            var unspentOutputs = client.UnspentOutputs
                .Where(u => u.Address == "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
                .ToArray();
            Console.WriteLine(unspentOutputs.Count());

            var latestBlockHash = latestBlock.Hash.ToString();
            var inventoryData = client.InventoryData
                .Where(i => i.HashString == latestBlockHash) //"000000000000000000575193009e04e9ca091510d63478b7bbaab4ab8382d629")
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(inventoryData?.Hash);

            Console.ReadKey();
        }
    }
}