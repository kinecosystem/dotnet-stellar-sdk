// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses
{
    /// <summary>
    /// Fee is too small.
    /// </summary>
    public class TransactionResultInsufficientFee : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}
