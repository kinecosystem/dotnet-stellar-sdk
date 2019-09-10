// This file was modified by Kin Ecosystem (2019)


using System.Collections.Generic;
using Kin.Base.responses.results;

namespace Kin.Base.responses
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
