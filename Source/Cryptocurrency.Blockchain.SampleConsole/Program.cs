using System;
using System.Linq;

namespace Cryptocurrency.Blockchain.SampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

            var addresses = client.Addresses2
                .Where(b => b.Addresses == "1FW8KHjgtPTngKLHAw4YALtWoENsRpjt33|1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
                .ToArray();
            Console.WriteLine(addresses?.Count());

            var miningPool = "Eligius";
            var fiveDaysAgo = new DateTimeOffset(DateTime.UtcNow - TimeSpan.FromDays(5)).ToUnixTimeMilliseconds();
            var minedBlocks = client.MinedBlocks
                .Where(b => b.MiningPool == miningPool)
                //.Where(b => b.DayInUnixTimeMilliseconds == fiveDaysAgo)
                .ToArray();
            Console.WriteLine(minedBlocks?.Count());

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
                .ToArray();
            Console.WriteLine(unconfirmedTransactions?.Count());

            var unspentOutputs = client.UnspentOutputs
                .Where(u => u.Address == "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
                .ToArray();
            Console.WriteLine(unspentOutputs.Count());

            var inventoryData = client.InventoryData
                .Where(i => i.Hash == latestBlock.Hash)
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(inventoryData?.Hash);

            Console.ReadKey();
        }
    }
}