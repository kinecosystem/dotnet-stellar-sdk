// This file was modified by Kin Ecosystem (2019)


using Newtonsoft.Json;

namespace kin_base.responses.operations
{
    /// <summary>
    /// Represents ManageData operation response.
    /// See: https://www.stellar.org/developers/horizon/reference/resources/operation.html
    /// <seealso cref="requests.OperationsRequestBuilder"/>
    /// <seealso cref="Server"/>
    /// </summary>
    public class ManageDataOperationResponse : OperationResponse
    {
        public override int TypeId => 10;

        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public string Value { get; private set; }

        public ManageDataOperationResponse()
        {

        }

        public ManageDataOperationResponse(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}