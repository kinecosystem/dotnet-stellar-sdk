// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses.results
{
    /// <summary>
    /// Offer created.
    /// </summary>
    public class ManageSellOfferCreated : ManageSellOfferSuccess
    {
        /// <summary>
        /// The offer that was created.
        /// </summary>
        public OfferEntry Offer { get; set; }
    }
}