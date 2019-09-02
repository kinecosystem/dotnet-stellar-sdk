// This file was modified by Kin Ecosystem (2019)


using Newtonsoft.Json;
using kin_base.responses.operations;

namespace kin_base.responses
{
    public class TradeResponseLinks
    {
        public TradeResponseLinks(Link<AssetResponse> baseLink, Link<AssetResponse> counterLink, Link<OperationResponse> operationLink)
        {
            Base = baseLink;
            Counter = counterLink;
            Operation = operationLink;
        }

        [JsonProperty(PropertyName = "base")]
        public Link<AssetResponse> Base;

        [JsonProperty(PropertyName = "counter")]
        public Link<AssetResponse> Counter;

        [JsonProperty(PropertyName = "operation")]
        public Link<OperationResponse> Operation;
    }
}