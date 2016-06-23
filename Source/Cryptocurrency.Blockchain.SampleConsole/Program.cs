using System;
using System.Linq;

namespace Cryptocurrency.Blockchain.SampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

            //var rawBlocks = from r in client.RawBlocks where r.BlockIndex == 417260 select r;
            //var rawBlock = rawBlocks.ToArray().SingleOrDefault();
            //Console.WriteLine(rawBlock?.Index);

            //var transactions = from t in client.Transactions where t.Index == 57048523 select t;
            //var transaction = transactions.ToArray().SingleOrDefault();
            //Console.WriteLine(transaction?.Index);

            var addresses = from a in client.Addresses where a.Hash160 == "660d4ef3a743e3e696ad990364e555c271ad504b" select a;
            var address = addresses.ToArray().SingleOrDefault();
            Console.WriteLine(address?.Base58);

            Console.ReadKey();
        }
    }
}