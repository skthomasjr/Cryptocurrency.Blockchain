using Newtonsoft.Json.Serialization;
using System;

namespace Cryptocurrency.Blockchain.Serialization
{
    public class ContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Address": return base.ResolvePropertyName("addr");
                case "Bits": return base.ResolvePropertyName("bits");
                case "BlockIndex": return base.ResolvePropertyName("block_index");
                case "Fee": return base.ResolvePropertyName("fee");
                case "Hash": return base.ResolvePropertyName("hash");
                case "Height": return base.ResolvePropertyName("height");
                case "Index": return base.ResolvePropertyName("n");
                case "Inputs": return base.ResolvePropertyName("inputs");
                case "IsMainChain": return base.ResolvePropertyName("main_chain");
                case "LockTime": return base.ResolvePropertyName("lock_time");
                case "MerkleRoot": return base.ResolvePropertyName("mrkl_root");
                case "Nonce": return base.ResolvePropertyName("nonce");
                case "Outputs": return base.ResolvePropertyName("out");
                case "PreviousBlock": return base.ResolvePropertyName("prev_block");
                case "PreviousOutput": return base.ResolvePropertyName("prev_out");
                case "ReceivedTime": return base.ResolvePropertyName("received_time");
                case "RelayedBy": return base.ResolvePropertyName("relayed_by");
                case "Script": return base.ResolvePropertyName("script");
                case "Sequence": return base.ResolvePropertyName("sequence");
                case "Size": return base.ResolvePropertyName("size");
                case "Spent": return base.ResolvePropertyName("spent");
                case "Time": return base.ResolvePropertyName("time");
                case "TransactionCount": return base.ResolvePropertyName("n_tx");
                case "TransactionIndex": return base.ResolvePropertyName("tx_index");
                case "Transactions": return base.ResolvePropertyName("tx");
                case "Type": return base.ResolvePropertyName("type");
                case "Value": return base.ResolvePropertyName("value");
                case "VectorInputSize": return base.ResolvePropertyName("vin_sz");
                case "VectorOutputSize": return base.ResolvePropertyName("vout_sz");
                case "Version": return base.ResolvePropertyName("ver");
                default: throw new NotImplementedException($"Unable to resolve property name {propertyName}.");
            }
        }
    }
}
