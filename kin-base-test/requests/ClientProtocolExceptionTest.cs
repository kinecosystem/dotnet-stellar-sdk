// This file was modified by Kin Ecosystem (2019)


using Microsoft.VisualStudio.TestTools.UnitTesting;
using kin_base.requests;

namespace kin_base_test.requests
{
    [TestClass]
    public class ClientProtocolExceptionTest
    {
        [TestMethod]
        public void TestCreation()
        {
            var clientProtocolException = new ClientProtocolException("Test");
            Assert.AreEqual("Test", clientProtocolException.Message);
        }

        [TestMethod]
        [ExpectedException(typeof(ClientProtocolException))]
        public void TestThrow()
        {
            throw new ClientProtocolException("Test");
        }
    }
}