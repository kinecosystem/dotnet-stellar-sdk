// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses.effects
{
    /// <summary>
    ///     Represents signer_updated effect response.
    ///     See: https://www.stellar.org/developers/horizon/reference/resources/effect.html
    ///     <seealso cref="requests.EffectsRequestBuilder" />
    ///     <seealso cref="Server" />
    /// </summary>
    public class SignerUpdatedEffectResponse : SignerEffectResponse
    {
        public override int TypeId => 12;

        public SignerUpdatedEffectResponse()
        {

        }

        /// <inheritdoc />
        public SignerUpdatedEffectResponse(int weight, string publicKey)
            : base(weight, publicKey)
        {
        }
    }
}
