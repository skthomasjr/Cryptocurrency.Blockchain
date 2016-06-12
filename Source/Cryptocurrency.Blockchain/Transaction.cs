using System;
using System.Collections.Generic;

namespace Cryptocurrency.Blockchain
{
    public class Transaction
    {
        public HexString Hash { get; set; }

        public long TransactionIndex { get; set; }

        public DateTime? LockTime { get; set; }

        public string RelayedBy { get; set; }

        public int Size { get; set; }

        public int VectorInputSize { get; set; }

        public int VectorOutputSize { get; set; }

        public int Version { get; set; }

        public IEnumerable<InputTransaction> Inputs { get; set; }

        public IEnumerable<OutputTransaction> Outputs { get; set; }
    }
}
