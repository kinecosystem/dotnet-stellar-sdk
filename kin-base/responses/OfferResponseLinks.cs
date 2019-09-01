using Newtonsoft.Json;

namespace kin_base.responses
{
    public class OfferResponseLinks
    {
        public OfferResponseLinks(Link<OfferResponse> self, Link<AccountResponse> offerMaker)
        {
            Self = self;
            OfferMaker = offerMaker;
        }

        [JsonProperty(PropertyName = "self")]
        public Link<OfferResponse> Self { get; private set; }

        [JsonProperty(PropertyName = "offer_maker")]
        public Link<AccountResponse> OfferMaker { get; private set; }
    }
}