using System;
using System.Linq;
using NetClient;
using Newtonsoft.Json;
using Types.Hexadecimal;

namespace Cryptocurrency.Blockchain.SampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

            //var address = client.Addresses
            //    .Where(a => a.Base58 == "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
            //    .ToArray()
            //    .SingleOrDefault();
            //Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));

            var address = client.Addresses
                .Where(a => a.Hash160 == "e6fd80cf7a96cec946e8ffa13573fb946a5e0980051f739c97ba31bc4a3d7fc1")
                .ToArray()
                .SingleOrDefault();
            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));

            //var block = client.Blocks
            //    .Where(b => b.Index == 417260)
            //    .ToArray()
            //    .SingleOrDefault();
            //Console.WriteLine(JsonConvert.SerializeObject(block, Formatting.Indented));

            ////var block = client.Blocks
            ////    .Where(b => b.Hash == "000000000000034a7dedef4a161fa058a2d67a173a90155f3a2fe6fc132e0ebf}")
            ////    .ToArray()
            ////    .SingleOrDefault();
            ////Console.WriteLine(JsonConvert.SerializeObject(block, Formatting.Indented));

            //var block = client.Blocks
            //    .Where(b => b.Height == 234003)
            //    .ToArray()
            //    .SingleOrDefault();
            //Console.WriteLine(JsonConvert.SerializeObject(block, Formatting.Indented));

            ////var inventoryData = client.InventoryData
            ////    .Where(i => i.Hash == latestBlock.Hash)
            ////    .ToArray()
            ////    .SingleOrDefault();
            ////Console.WriteLine(inventoryData?.Hash);

            //var latestBlock = client.LatestBlocks
            //    .ToArray()
            //    .SingleOrDefault();
            //Console.WriteLine(JsonConvert.SerializeObject(latestBlock, Formatting.Indented));

            //var minedBlock = client.MinedBlocks
            //    .Where(m => Configuration.Criteria == new { MiningPool = "Eligius" })
            //    .ToArray();
            //Console.WriteLine(JsonConvert.SerializeObject(minedBlock, Formatting.Indented));

            //var fiveDaysAgo = new DateTimeOffset(DateTime.UtcNow - TimeSpan.FromDays(5)).ToUnixTimeMilliseconds();
            //var minedBlock = client.MinedBlocks
            //    .Where(m => Configuration.Criteria == new { DayInUnixTimeMilliseconds = fiveDaysAgo })
            //    .ToArray();
            //Console.WriteLine(JsonConvert.SerializeObject(minedBlock, Formatting.Indented));

            ////var addresses = client.MultiAddresses
            ////    .Where(b => b.Addresses == "1FW8KHjgtPTngKLHAw4YALtWoENsRpjt33|1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
            ////    .ToArray();
            ////Console.WriteLine(addresses?.Count());

            //var transaction = client.Transactions
            //    .Where(t => t.Index == 57048523)
            //    .ToArray()
            //    .SingleOrDefault();
            //Console.WriteLine(JsonConvert.SerializeObject(transaction, Formatting.Indented));

            ////var transaction = client.Transactions
            ////    .Where(t => t.Hash == "6c517095e783325856c0313cefdc96a716fc6a1aedb695068d3fc54e14280b68")
            ////    .ToArray()
            ////    .SingleOrDefault();
            ////Console.WriteLine(JsonConvert.SerializeObject(transaction, Formatting.Indented));

            //var transactions = client.Transactions.ToArray();
            //Console.WriteLine(JsonConvert.SerializeObject(transactions, Formatting.Indented));

            ////var unspentOutputs = client.UnspentOutputs
            ////    .Where(u => u.Address == "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
            ////    .ToArray();
            ////Console.WriteLine(unspentOutputs.Count());

            Console.ReadKey();
        }
    }
}