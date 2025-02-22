// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses.effects
{
    /// <summary>
    ///     Represents trustline_removed effect response.
    ///     See: https://www.stellar.org/developers/horizon/reference/resources/effect.html
    ///     <seealso cref="requests.EffectsRequestBuilder" />
    ///     <seealso cref="Server" />
    /// </summary>
    public class TrustlineRemovedEffectResponse : TrustlineCUDResponse
    {
        public override int TypeId => 21;

        public TrustlineRemovedEffectResponse()
        {

        }

        /// <inheritdoc />
        public TrustlineRemovedEffectResponse(string limit, string assetType, string assetCode, string assetIssuer)
            : base(limit, assetType, assetCode, assetIssuer)
        {
        }
    }
}
