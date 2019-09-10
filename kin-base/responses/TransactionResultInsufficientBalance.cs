// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses
{
    /// <summary>
    /// Fee would bring account below reserve.
    /// </summary>
    public class TransactionResultInsufficientBalance : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}
