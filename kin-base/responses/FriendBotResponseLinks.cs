// This file was modified by Kin Ecosystem (2019)


using Newtonsoft.Json;

namespace kin_base.responses
{
    public class FriendBotResponseLinks
    {
        [JsonProperty(PropertyName = "transaction")]
        public Link<TransactionResponse> Transaction { get; private set; }
    }
}