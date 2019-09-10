// This file was modified by Kin Ecosystem (2019)


using Newtonsoft.Json;

namespace Kin.Base.responses.operations
{
    /// <summary>
    /// Represents CreateAccount operation response.
    /// See: https://www.stellar.org/developers/horizon/reference/resources/operation.html
    /// <seealso cref="requests.OperationsRequestBuilder"/>
    /// <seealso cref="Server"/>
    /// </summary>
    public class CreateAccountOperationResponse : OperationResponse
    {
        public override int TypeId => 0;

        [JsonProperty(PropertyName = "account")]
        public string Account { get; private set; }

        [JsonProperty(PropertyName = "funder")]
        public string Funder { get; private set; }

        [JsonProperty(PropertyName = "starting_balance")]
        public string StartingBalance { get; private set; }

        public CreateAccountOperationResponse()
        {

        }

        public CreateAccountOperationResponse(string account, string funder, string startingBalance)
        {
            Account = account;
            Funder = funder;
            StartingBalance = startingBalance;
        }
    }
}
