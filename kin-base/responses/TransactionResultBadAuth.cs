// This file was modified by Kin Ecosystem (2019)


namespace kin_base.responses
{
    /// <summary>
    /// Too few valid signatures or invalid network.
    /// </summary>
    public class TransactionResultBadAuth : TransactionResult
    {
        public override bool IsSuccess => false;
    }
}