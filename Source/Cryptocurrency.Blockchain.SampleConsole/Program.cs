using System;
using System.Linq;
using NetClient;
using Newtonsoft.Json;

namespace Cryptocurrency.Blockchain.SampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

            var address = client.Addresses
                .Where(a => Configuration.Criteria == new { Limit = 10, Offset = 0 } && a.Base58 == "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));

            address = client.Addresses
                .Where(a => Configuration.Criteria == new { Limit = 10, Offset = 0 } && a.Hash160 == "62e907b15cbf27d5425399ebf6f0fb50ebb88f18")
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));

            var block = client.Blocks
                .Where(b => b.Index == 417260)
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(block, Formatting.Indented));

            block = client.Blocks
                .Where(b => b.Hash == "000000000000034a7dedef4a161fa058a2d67a173a90155f3a2fe6fc132e0ebf")
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(block, Formatting.Indented));

            block = client.Blocks
                .Where(b => b.Height == 234003)
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(block, Formatting.Indented));

            var latestBlock = client.LatestBlocks
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(latestBlock, Formatting.Indented));

            var inventoryData = client.InventoryData
                .Where(i => i.Hash == latestBlock.Hash)
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(inventoryData, Formatting.Indented));

            var minedBlock = client.MinedBlocks
                .Where(m => Configuration.Criteria == new { MiningPool = "Eligius" })
                .ToArray();
            Console.WriteLine(JsonConvert.SerializeObject(minedBlock, Formatting.Indented));

            var fiveDaysAgo = new DateTimeOffset(DateTime.UtcNow - TimeSpan.FromDays(5)).ToUnixTimeMilliseconds();
            minedBlock = client.MinedBlocks
                .Where(m => Configuration.Criteria == new { DayInUnixTimeMilliseconds = fiveDaysAgo })
                .ToArray();
            Console.WriteLine(JsonConvert.SerializeObject(minedBlock, Formatting.Indented));

            var addresses = client.MultiAddresses
                .Where(b => Configuration.Criteria == new
                {
                    Addresses = "1EBHA1ckUWzNKN7BMfDwGTx6GKEbADUozX|1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"
                })
                .ToArray();
            Console.WriteLine(JsonConvert.SerializeObject(addresses, Formatting.Indented));

            //Optional scripts boolean parameter to include the input and output scripts e.g. & scripts = true
            //You can also request the transaction in binary form (Hex encoded) using ? format = hex
            var transaction = client.Transactions
                .Where(t => t.Index == 57048523)
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(transaction, Formatting.Indented));

            transaction = client.Transactions
                .Where(t => t.Hash == "6c517095e783325856c0313cefdc96a716fc6a1aedb695068d3fc54e14280b68")
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(transaction, Formatting.Indented));

            var transactions = client.Transactions
                .ToArray();
            Console.WriteLine(JsonConvert.SerializeObject(transactions, Formatting.Indented));

            var unspentOutputs = client.UnspentOutputs
                .Where(u => Configuration.Criteria == new
                {
                    Address = "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"
                })
                .ToArray();
            Console.WriteLine(JsonConvert.SerializeObject(unspentOutputs, Formatting.Indented));

            unspentOutputs = client.UnspentOutputs
                .Where(u => Configuration.Criteria == new
                {
                    Addresses = "1EBHA1ckUWzNKN7BMfDwGTx6GKEbADUozX|1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"
                })
                .ToArray();
            Console.WriteLine(JsonConvert.SerializeObject(unspentOutputs, Formatting.Indented));

            Console.ReadKey();
        }
    }
}