// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses.results
{
    /// <summary>
    /// Operation successful.
    /// </summary>
    public class PathPaymentSuccess : PathPaymentResult
    {
        public override bool IsSuccess => true;

        /// <summary>
        /// Offers claimed in this payment.
        /// </summary>
        public ClaimOfferAtom[] Offers { get; set; }

        /// <summary>
        /// Payment result.
        /// </summary>
        public SimplePaymentResult Last { get; set; }

        public class SimplePaymentResult
        {
            public KeyPair Destination { get; set; }
            public Asset Asset { get; set; }
            public string Amount { get; set; }

            public static SimplePaymentResult FromXdr(xdr.SimplePaymentResult result)
            {
                return new SimplePaymentResult
                {
                    Destination = KeyPair.FromXdrPublicKey(result.Destination.InnerValue),
                    Asset = Asset.FromXdr(result.Asset),
                    Amount = kin_base.Amount.FromXdr(result.Amount.InnerValue)
                };
            }
        }
    }
}