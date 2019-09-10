// This file was modified by Kin Ecosystem (2019)


using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kin.Base.requests;

namespace kin_base_test.requests
{
    [TestClass]
    public class TooManyRequestsExceptionTest
    {
        [TestMethod]
        public void TestCreation()
        {
            var clientProtocolException = new TooManyRequestsException(4);
            Assert.AreEqual(4, clientProtocolException.RetryAfter);
        }

        [TestMethod]
        [ExpectedException(typeof(TooManyRequestsException))]
        public void TestThrow()
        {
            throw new TooManyRequestsException(4);
        }
    }
}
