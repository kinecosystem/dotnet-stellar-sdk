// This file was modified by Kin Ecosystem (2019)


using System.Collections.Generic;
using kin_base.responses.results;

namespace kin_base.responses
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