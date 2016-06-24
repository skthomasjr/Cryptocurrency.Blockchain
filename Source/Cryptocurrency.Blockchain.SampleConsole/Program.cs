using System;
using System.Linq;

namespace Cryptocurrency.Blockchain.SampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

            var addresses = from a in client.Addresses where a.Base58 == "1FW8KHjgtPTngKLHAw4YALtWoENsRpjt33" select a;
            var address = addresses.ToArray().SingleOrDefault();
            Console.WriteLine(address?.Base58);

            var latestBlocks = from r in client.LatestBlocks select r;
            var latestBlock = latestBlocks.ToArray().SingleOrDefault();
            Console.WriteLine(latestBlock?.Index);

            var rawBlocks = from r in client.RawBlocks where r.Index == 417260 select r;
            var rawBlock = rawBlocks.ToArray().SingleOrDefault();
            Console.WriteLine(rawBlock?.Index);

            var transactions = from t in client.Transactions where t.Index == 57048523 select t;
            var transaction = transactions.ToArray().SingleOrDefault();
            Console.WriteLine(transaction?.Index);

            Console.ReadKey();
        }
    }
}