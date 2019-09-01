using System;
using System.Net.Http;
using System.Threading.Tasks;
using kin_base.responses;
using kin_base.responses.page;

namespace kin_base.requests
{
    /// <summary>
    /// Builds requests connected to paths.
    /// </summary>
    public class PathsRequestBuilder : RequestBuilderExecutePageable<PathsRequestBuilder, PathResponse>
    {
        public PathsRequestBuilder(Uri serverUri, HttpClient httpClient)
            : base(serverUri, "paths", httpClient)
        {
        }

        public PathsRequestBuilder DestinationAccount(string account)
        {
            UriBuilder.SetQueryParam("destination_account", account);
            return this;
        }

        public PathsRequestBuilder SourceAccount(string account)
        {
            UriBuilder.SetQueryParam("source_account", account);
            return this;
        }

        public PathsRequestBuilder DestinationAmount(string amount)
        {
            UriBuilder.SetQueryParam("destination_amount", amount);
            return this;
        }

        public PathsRequestBuilder DestinationAsset(Asset asset)
        {
            UriBuilder.SetQueryParam("destination_asset_type", asset.GetType());

            if (asset is AssetTypeCreditAlphaNum)
            {
                AssetTypeCreditAlphaNum creditAlphaNumAsset = (AssetTypeCreditAlphaNum) asset;
                UriBuilder.SetQueryParam("destination_asset_code", creditAlphaNumAsset.Code);
                UriBuilder.SetQueryParam("destination_asset_issuer", creditAlphaNumAsset.Issuer);
            }

            return this;
        }
    }
}