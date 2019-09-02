// This file was modified by Kin Ecosystem (2019)


using kin_base.responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using kin_base.responses.operations;

namespace kin_base.requests
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
