// This file was modified by Kin Ecosystem (2019)


using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kin.Base.responses.results;

namespace kin_base_test.responses.results
{
    [TestClass]
    public class ChangeTrustResultTest
    {
        [TestMethod]
        public void TestSuccess()
        {
            Util.AssertResultOfType("AAAAAACYloD/////AAAAAQAAAAAAAAAGAAAAAAAAAAA=", typeof(ChangeTrustSuccess), true);
        }

        [TestMethod]
        public void TestMalformed()
        {
            Util.AssertResultOfType("AAAAAACYloD/////AAAAAQAAAAAAAAAG/////wAAAAA=", typeof(ChangeTrustMalformed),
                false);
        }

        [TestMethod]
        public void TestNoIssuer()
        {
            Util.AssertResultOfType("AAAAAACYloD/////AAAAAQAAAAAAAAAG/////gAAAAA=", typeof(ChangeTrustNoIssuer), false);
        }

        [TestMethod]
        public void TestInvalidLimit()
        {
            Util.AssertResultOfType("AAAAAACYloD/////AAAAAQAAAAAAAAAG/////QAAAAA=", typeof(ChangeTrustInvalidLimit),
                false);
        }

        [TestMethod]
        public void TestLowReserve()
        {
            Util.AssertResultOfType("AAAAAACYloD/////AAAAAQAAAAAAAAAG/////AAAAAA=", typeof(ChangeTrustLowReserve),
                false);
        }

        [TestMethod]
        public void TestSelfNotAllowed()
        {
            Util.AssertResultOfType("AAAAAACYloD/////AAAAAQAAAAAAAAAG////+wAAAAA=", typeof(ChangeTrustSelfNotAllowed),
                false);
        }
    }
}
