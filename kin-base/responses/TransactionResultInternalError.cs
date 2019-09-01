// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses
{
    /// <summary>
    /// An unknown error occured.
    /// </summary>
    public class TransactionResultInternalError : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}