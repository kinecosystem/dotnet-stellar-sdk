// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses
{
    /// <summary>
    /// Source account not found.
    /// </summary>
    public class TransactionResultNoAccount : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}
