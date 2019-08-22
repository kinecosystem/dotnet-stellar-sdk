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