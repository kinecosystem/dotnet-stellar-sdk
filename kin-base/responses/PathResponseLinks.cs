using Newtonsoft.Json;

namespace kin_base.responses
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