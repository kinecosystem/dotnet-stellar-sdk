// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses.effects
{
    /// <summary>
    ///     Represents offer_removed effect response.
    ///     See: https://www.stellar.org/developers/horizon/reference/resources/effect.html
    ///     <seealso cref="requests.EffectsRequestBuilder" />
    ///     <seealso cref="Server" />
    /// </summary>
    public class OfferRemovedEffectResponse : EffectResponse
    {
        public override int TypeId => 31;
    }
}