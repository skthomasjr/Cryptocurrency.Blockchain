using System;
using System.Linq;

namespace Cryptocurrency.Blockchain.SampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

            var rawBlocks = from r in client.RawBlocks where r.BlockIndex == 417260 select r;
            var rawBlock = rawBlocks.ToArray().SingleOrDefault();

            Console.WriteLine(rawBlock?.BlockIndex);
            Console.ReadKey();
        }
    }
}