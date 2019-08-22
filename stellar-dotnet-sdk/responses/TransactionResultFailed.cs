using System.Collections.Generic;
using kin_base.responses.results;

namespace kin_base.responses
{
    /// <summary>
    /// One of the operations failed (none were applied).
    /// </summary>
    public class TransactionResultFailed : TransactionResult
    {
        public override bool IsSuccess => false;

        public IList<OperationResult> Results { get; set; }
    }
}