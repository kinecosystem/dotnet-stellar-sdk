// This file was modified by Kin Ecosystem (2019)


using Kin.Base.responses;
using Kin.Base.responses.page;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kin.Base.requests
{
    /// <summary>
    /// 
    /// </summary>
    public class AssetsRequestBuilder : RequestBuilderExecutePageable<AssetsRequestBuilder, AssetResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverUri"></param>
        public AssetsRequestBuilder(Uri serverUri, HttpClient httpClient)
            : base(serverUri, "assets", httpClient)
        {
        }

        /// <summary>
        /// Code of the Asset to filter by
        /// </summary>
        /// <param name="assetCode"></param>
        /// <returns></returns>
        public AssetsRequestBuilder AssetCode(string assetCode)
        {
            UriBuilder.SetQueryParam("asset_code", assetCode);
            return this;
        }

        /// <summary>
        /// Issuer of the Asset to filter by
        /// </summary>
        /// <param name="assetIssuer"></param>
        /// <returns></returns>
        public AssetsRequestBuilder AssetIssuer(string assetIssuer)
        {
            UriBuilder.SetQueryParam("asset_issuer", assetIssuer);
            return this;
        }
    }
}
