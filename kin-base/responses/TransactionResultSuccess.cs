// This file was modified by Kin Ecosystem (2019)


using System.Collections.Generic;
using Kin.Base.responses.results;

namespace Kin.Base.responses
{
    /// <summary>
    /// All operations succeded.
    /// </summary>
    public class TransactionResultSuccess : TransactionResult
    {
        public override bool IsSuccess => true;

        public ICollection<OperationResult> Results { get; set; }
    }
}
