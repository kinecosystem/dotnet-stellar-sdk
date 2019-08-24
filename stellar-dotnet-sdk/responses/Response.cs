using System.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace stellar_dotnet_sdk.responses
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class Response
    {
        protected int RateLimitLimit { get; private set; } = 101;

        protected int RateLimitRemaining { get; private set; } = 100;

        protected int RateLimitReset { get; private set; } = 1;

        public void SetHeaders(HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("X-Ratelimit-Limit", out var rateLimit))
            {
                RateLimitLimit = int.Parse(rateLimit.FirstOrDefault() ?? "101");
            }
            if (headers.TryGetValues("X-Ratelimit-Remaining", out var rateLimitRemaining))
            {
                RateLimitRemaining = int.Parse(rateLimitRemaining.FirstOrDefault() ?? "100");
            }
            if (headers.TryGetValues("X-Ratelimit-Reset", out var rateLimitReset))
            {
                RateLimitReset = int.Parse(rateLimitReset.FirstOrDefault() ?? "1");
            }
        }
    }
}
