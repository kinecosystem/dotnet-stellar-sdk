// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses
{
    /// <summary>
    /// No operation was specified.
    /// </summary>
    public class TransactionResultMissingOperation : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}
