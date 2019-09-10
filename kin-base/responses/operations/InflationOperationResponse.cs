// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses.operations
{
    /// <summary>
    /// Represents Inflation operation response.
    /// See: https://www.stellar.org/developers/horizon/reference/resources/operation.html
    /// <seealso cref="requests.OperationsRequestBuilder"/>
    /// <seealso cref="Server"/>
    /// </summary>
    public class InflationOperationResponse : OperationResponse
    {
        public override int TypeId => 9;

        public InflationOperationResponse()
        {

        }
    }
}
