// This file was modified by Kin Ecosystem (2019)


using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kin_base;
using kin_base.requests;
using kin_base_test.responses;

namespace kin_base_test.requests
{
    [TestClass]
    public class OffersRequestBuilderTest
    {
        [TestMethod]
        public void TestForAccount()
        {
            using (var server = new Server("https://horizon-testnet.stellar.org"))
            {
                var uri = server.Offers
                    .ForAccount("GBRPYHIL2CI3FNQ4BXLFMNDLFJUNPU2HY3ZMFSHONUCEOASW7QC7OX2H")
                    .Limit(200)
                    .Order(OrderDirection.DESC)
                    .BuildUri();
                Assert.AreEqual("https://horizon-testnet.stellar.org/accounts/GBRPYHIL2CI3FNQ4BXLFMNDLFJUNPU2HY3ZMFSHONUCEOASW7QC7OX2H/offers?limit=200&order=desc", uri.ToString());
            }
        }

        [TestMethod]
        public async Task TestOffersExecute()
        {
            var jsonResponse = File.ReadAllText(Path.Combine("testdata", "offerPage.json"));
            var fakeHttpClient = FakeHttpClient.CreateFakeHttpClient(jsonResponse);

            using (var server = new Server("https://horizon-testnet.stellar.org", fakeHttpClient))
            {
                var offerResponsePage = await server.Offers.ForAccount("GAAZI4TCR3TY5OJHCTJC2A4QSY6CJWJH5IAJTGKIN2ER7LBNVKOCCWN7")
                    .Execute();

                OfferPageDeserializerTest.AssertTestData(offerResponsePage);
            }
        }
    }
}