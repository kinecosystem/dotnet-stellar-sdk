// This file was modified by Kin Ecosystem (2019)


using Microsoft.VisualStudio.TestTools.UnitTesting;
using kin_base;

namespace kin_base_test
{
    [TestClass]
    public class AccountFlagTest
    {
        [TestMethod]
        public void TestValues()
        {
            Assert.AreEqual(1, (int) AccountFlag.AuthRequiredFlag);
            Assert.AreEqual(2, (int) AccountFlag.AuthRevocableFlag);
            Assert.AreEqual(4, (int) AccountFlag.AuthImmutableFlag);
        }
    }
}