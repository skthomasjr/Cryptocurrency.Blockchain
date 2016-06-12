namespace Cryptocurrency.Blockchain
{
    public class OutputTransaction
    {
        public string Address { get; set; }

        public int Index { get; set; }

        public string Script { get; set; }

        public bool Spent { get; set; }

        public long TransactionIndex { get; set; }

        public int Type { get; set; }

        public long Value { get; set; }
    }
}
