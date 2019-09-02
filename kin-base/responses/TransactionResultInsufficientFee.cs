// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses
{
    /// <summary>
    /// Fee is too small.
    /// </summary>
    public class TransactionResultInsufficientFee : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}