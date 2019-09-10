// This file was modified by Kin Ecosystem (2019)


using Kin.Base.responses;
using Kin.Base.responses.page;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kin.Base.requests
{
    /// <inheritdoc />
    public class OffersRequestBuilder : RequestBuilderExecutePageable<OffersRequestBuilder, OfferResponse>
    {
        public OffersRequestBuilder(Uri serverURI, HttpClient httpClient) :
            base(serverURI, "offers", httpClient)
        {
        }

        /// <summary>
        /// Builds request to GET /accounts/{account}/offers
        /// See: https://www.stellar.org/developers/horizon/reference/offers-for-account.html
        /// </summary>
        /// <param name="account">Account for which to get offers</param>
        /// <returns></returns>
        public OffersRequestBuilder ForAccount(string account)
        {
            account = account ?? throw new ArgumentNullException(nameof(account), "account cannot be null");
            this.SetSegments("accounts", account, "offers");
            return this;
        }
    }
}
