// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses
{
    /// <summary>
    /// Ledger closeTime after maxTime.
    /// </summary>
    public class TransactionResultTooLate : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}
