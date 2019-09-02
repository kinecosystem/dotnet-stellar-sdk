// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses.results
{
    /// <summary>
    /// Missing issuer on one asset.
    /// </summary>
    public class PathPaymentNoIssuer : PathPaymentResult
    {
        /// <summary>
        /// The asset that caused the error.
        /// </summary>
        public Asset NoIssuer { get; set; }
    }
}