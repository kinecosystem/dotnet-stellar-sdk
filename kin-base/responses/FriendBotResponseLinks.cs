using Newtonsoft.Json;

namespace kin_base.responses
{
    public class FriendBotResponseLinks
    {
        [JsonProperty(PropertyName = "transaction")]
        public Link<TransactionResponse> Transaction { get; private set; }
    }
}