// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses.effects
{
    /// <summary>
    ///     Represents account_removed effect response.
    ///     See: https://www.stellar.org/developers/horizon/reference/resources/effect.html
    ///     <seealso cref="requests.EffectsRequestBuilder" />
    ///     <seealso cref="Server" />
    /// </summary>
    public class AccountRemovedEffectResponse : EffectResponse
    {
        public override int TypeId => 1;
    }
}
