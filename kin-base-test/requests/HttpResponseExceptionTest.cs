// This file was modified by Kin Ecosystem (2019)


using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kin.Base.requests;

namespace kin_base_test.requests
{
    [TestClass]
    public class HttpResponseExceptionTest
    {
        [TestMethod]
        public void TestCreation()
        {
            var clientProtocolException = new HttpResponseException(200, "Test");
            Assert.AreEqual("Test", clientProtocolException.Message);
            Assert.AreEqual(200, clientProtocolException.StatusCode);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpResponseException))]
        public void TestThrow()
        {
            throw new HttpResponseException(200, "Test");
        }
    }
}
