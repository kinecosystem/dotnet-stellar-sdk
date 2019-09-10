// This file was modified by Kin Ecosystem (2019)


using Newtonsoft.Json;

namespace Kin.Base.responses
{
    public class PathResponseLinks
    {
        [JsonProperty(PropertyName = "self")]
        public Link<PathResponse> Self { get; }

        public PathResponseLinks(Link<PathResponse> self)
        {
            Self = self;
        }
    }
}
