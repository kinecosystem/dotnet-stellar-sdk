// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses
{
    /// <summary>
    /// Sequence number does not match source account.
    /// </summary>
    public class TransactionResultBadSeq : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}
