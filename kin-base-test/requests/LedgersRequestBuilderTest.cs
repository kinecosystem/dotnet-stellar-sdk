// This file was modified by Kin Ecosystem (2019)


using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kin_base;
using kin_base.requests;
using kin_base.responses;
using kin_base_test.responses;

namespace kin_base_test.requests
{
    [TestClass]
    public class LedgersRequestBuilderTest
    {
        [TestMethod]
        public void TestAccounts()
        {
            using (var server = new Server("https://horizon-testnet.stellar.org"))
            {
                var uri = server.Ledgers
                    .Limit(200)
                    .Order(OrderDirection.ASC)
                    .BuildUri();
                Assert.AreEqual("https://horizon-testnet.stellar.org/ledgers?limit=200&order=asc", uri.ToString());
            }
        }

        [TestMethod]
        public async Task TestLedgersExecute()
        {
            var jsonResponse = File.ReadAllText(Path.Combine("testdata", "ledgerPage.json"));
            var fakeHttpClient = FakeHttpClient.CreateFakeHttpClient(jsonResponse);

            using (var server = new Server("https://horizon-testnet.stellar.org", fakeHttpClient))
            {
                var ledgersPage = await server.Ledgers
                    .Execute();

                LedgerPageDeserializerTest.AssertTestData(ledgersPage);
            }
        }

        [TestMethod]
        public void TestStream()
        {
            var json = File.ReadAllText(Path.Combine("testdata", "ledger.json"));
            var streamableTest = new StreamableTest<LedgerResponse>(json, LedgerDeserializeTest.AssertTestData);

            streamableTest.AssertIsValid();
        }
    }
}