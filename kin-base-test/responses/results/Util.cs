// This file was modified by Kin Ecosystem (2019)


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kin.Base.responses;

namespace kin_base_test.responses.results
{
    public static class Util
    {
        public static TransactionResult AssertResultOfType(string xdr, Type resultType, bool isSuccess)
        {
            var result = TransactionResult.FromXdr(xdr);
            Assert.IsInstanceOfType(result, typeof(TransactionResultFailed));
            var failed = (TransactionResultFailed) result;
            Assert.IsFalse(failed.IsSuccess);
            Assert.AreEqual(1, failed.Results.Count);
            Assert.IsInstanceOfType(failed.Results[0], resultType);
            Assert.AreEqual(isSuccess, failed.Results[0].IsSuccess);
            return result;
        }

    }
}
