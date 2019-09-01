using Newtonsoft.Json;

namespace kin_base.responses.effects
{
    /// <inheritdoc />
    public class SignerEffectResponse : EffectResponse
    {
        [JsonProperty(PropertyName = "weight")]
        public int Weight { get; private set; }

        [JsonProperty(PropertyName = "public_key")]
        public string PublicKey { get; private set; }

        public SignerEffectResponse()
        {

        }

        public SignerEffectResponse(int weight, string publicKey)
        {
            Weight = weight;
            PublicKey = publicKey;
        }
    }
}