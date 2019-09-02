// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses
{
    /// <summary>
    /// Unused signatures attached to the transaction.
    /// </summary>
    public class TransactionResultBadAuthExtra : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}