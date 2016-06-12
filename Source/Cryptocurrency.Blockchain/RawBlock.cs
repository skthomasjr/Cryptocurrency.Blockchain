using System;
using System.Collections.Generic;

namespace Cryptocurrency.Blockchain
{
    public class RawBlock
    {
        public int Bits { get; set; }

        public long Fee { get; set; }

        public HexString Hash { get; set; }

        public int Height { get; set; }

        public long BlockIndex { get; set; }

        public bool IsMainChain { get; set; }

        public HexString MerkleRoot { get; set; }

        public long Nonce { get; set; }

        public HexString PreviousBlock { get; set; }

        public string RelayedBy { get; set; }

        public int Size { get; set; }

        public DateTime Time { get; set; }

        public int TransactionCount { get; set; }

        public int Version { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; }
    }
}