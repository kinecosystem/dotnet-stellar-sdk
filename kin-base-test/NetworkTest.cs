// This file was modified by Kin Ecosystem (2019)


using Microsoft.VisualStudio.TestTools.UnitTesting;
using kin_base;

namespace kin_base_test
{
    [TestClass]
    public class NetworkTest
    {
        [TestCleanup]
        public void ResetNetwork()
        {
            Network.Use(null);
        }

        [TestMethod]
        public void TestNoDefaultNetwork()
        {
            Assert.IsNull(Network.Current);
        }

        [TestMethod]
        public void TestSwitchToTestNetwork()
        {
            Network.UseTestNetwork();
            Assert.AreEqual("Kin Testnet ; December 2018", Network.Current.NetworkPassphrase);
        }

        [TestMethod]
        public void TestSwitchToPublicNework()
        {
            Network.UsePublicNetwork();
            Assert.AreEqual("Kin Mainnet ; December 2018", Network.Current.NetworkPassphrase);
        }
    }
}
