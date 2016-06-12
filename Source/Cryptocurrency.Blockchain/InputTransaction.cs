namespace Cryptocurrency.Blockchain
{
    public class InputTransaction
    {
        public OutputTransaction PreviousOutput { get; set; }

        public string Script { get; set; }

        public long Sequence { get; set; }
    }
}
