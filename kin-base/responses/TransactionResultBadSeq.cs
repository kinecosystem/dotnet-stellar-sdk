// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses
{
    /// <summary>
    /// Sequence number does not match source account.
    /// </summary>
    public class TransactionResultBadSeq : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}