// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses.results
{
    /// <summary>
    /// Offer updated.
    /// </summary>
    public class ManageBuyOfferUpdated : ManageBuyOfferSuccess
    {
        /// <summary>
        /// The offer that was updated.
        /// </summary>
        public OfferEntry Offer { get; set; }
    }
}