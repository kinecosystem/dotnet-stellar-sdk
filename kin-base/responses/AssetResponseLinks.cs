// This file was modified by Kin Ecosystem (2019)


using Newtonsoft.Json;

namespace Kin.Base.responses
{
    /// <summary>
    ///
    /// </summary>
    public class AssetResponseLinks
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "toml")]
        public Link Toml { get; set; }

        public AssetResponseLinks(Link<AssetResponse> toml)
        {
            Toml = toml;
        }
    }
}
