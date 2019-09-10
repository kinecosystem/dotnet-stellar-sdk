// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses.effects
{
    /// <summary>
    ///     Represents trustline_deauthorized effect response.
    ///     See: https://www.stellar.org/developers/horizon/reference/resources/effect.html
    ///     <seealso cref="requests.EffectsRequestBuilder" />
    ///     <seealso cref="Server" />
    /// </summary>
    public class TrustlineDeauthorizedEffectResponse : TrustlineAuthorizationResponse
    {
        public override int TypeId => 24;

        public TrustlineDeauthorizedEffectResponse()
        {

        }

        /// <inheritdoc />
        public TrustlineDeauthorizedEffectResponse(string trustor, string assetType, string assetCode)
            : base(trustor, assetType, assetCode)
        {
        }
    }
}
