// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base
{
    /// <summary>
    /// Operation threshold level.
    /// </summary>
    public enum OperationThreshold
    {
        /// <summary>
        /// Low security level.
        /// <seealso cref="AllowTrustOperation"/>
        /// <seealso cref="BumpSequenceOperation"/>
        /// </summary>
        Low = 1,

        /// <summary>
        /// Medium security level.
        /// <seealso cref="ChangeTrustOperation"/>
        /// <seealso cref="CreateAccountOperation"/>
        /// <seealso cref="CreatePassiveSellOfferOperation"/>
        /// <seealso cref="ManageDataOperation"/>
        /// <seealso cref="ManageSellOfferOperation"/>
        /// <seealso cref="PathPaymentOperation"/>
        /// <seealso cref="PaymentOperation"/>
        /// </summary>
        Medium = 2,

        /// <summary>
        /// High security level.
        /// <seealso cref="SetOptionsOperation"/>
        /// <seealso cref="AccountMergeOperation"/>
        /// </summary>
        High = 3,
    }
}
