// This file was modified by Kin Ecosystem (2019)


using Newtonsoft.Json;

namespace kin_base.responses
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