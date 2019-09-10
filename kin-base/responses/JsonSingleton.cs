// This file was modified by Kin Ecosystem (2019)


using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Kin.Base.responses.effects;
using Kin.Base.responses.operations;
using Kin.Base.responses.page;

namespace Kin.Base.responses
{
    public static class JsonSingleton
    {
        public static T GetInstance<T>(string content)
        {
            var pageResponseConversions = new[]
            {
                typeof(Page<AccountResponse>),
                typeof(Page<AssetResponse>),
                typeof(Page<EffectResponse>),
                typeof(Page<LedgerResponse>),
                typeof(Page<OfferResponse>),
                typeof(Page<OperationResponse>),
                typeof(Page<PathResponse>),
                typeof(Page<TransactionResponse>),
                typeof(Page<TradeResponse>),
                typeof(Page<TradeAggregationResponse>),
                typeof(Page<TransactionResponse>)
            };

            var jsonConverters = new JsonConverter[]
            {
                new AssetDeserializer(),
                new KeyPairTypeAdapter(),
                new OperationDeserializer(),
                new EffectDeserializer()
            };

            var pageJsonConverters = new JsonConverter[]
            {
                new AssetDeserializer(),
                new KeyPairTypeAdapter(),
                new OperationDeserializer(),
                new EffectDeserializer()
            };

            if (pageResponseConversions.Contains(typeof(T)))
            {
                return JsonConvert.DeserializeObject<T>(content, pageJsonConverters);
            }

            return JsonConvert.DeserializeObject<T>(content, jsonConverters);
        }
    }
}
