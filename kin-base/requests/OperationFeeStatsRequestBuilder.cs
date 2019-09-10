// This file was modified by Kin Ecosystem (2019)


using Kin.Base.responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Kin.Base.responses.operations;

namespace Kin.Base.requests
{
    public class OperationFeeStatsRequestBuilder : RequestBuilder<OperationFeeStatsRequestBuilder>
    {
        public OperationFeeStatsRequestBuilder(Uri serverURI, HttpClient httpClient)
            : base(serverURI, "operation_fee_stats", httpClient)
        {
        }

        public async Task<OperationFeeStatsResponse> Execute()
        {
            return await Execute<OperationFeeStatsResponse>(BuildUri());
        }
    }
}
