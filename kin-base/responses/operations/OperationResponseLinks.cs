// This file was modified by Kin Ecosystem (2019)


using Newtonsoft.Json;
using Kin.Base.responses.effects;
using Kin.Base.responses.page;

namespace Kin.Base.responses.operations
{
    /// <summary>
    /// The response is for the genesis ledger of the Stellar network, and the links in the _links attribute provide links to other relavant resources in Horizon.
    /// The key of each link specifies that links relation to the current resource, and transactions means  “Transactions that occurred in this operation”.
    ///
    /// The transactions link is also templated, which means that the href attribute of the link is actually a URI template, as specified by RFC 6570. We use URI templates
    /// to show you what parameters a give resource can take.
    /// </summary>
    public class OperationResponseLinks
    {
        /// <summary>
        /// This endpoint represents effects that occurred as a result of a given operation.
        /// </summary>
        [JsonProperty(PropertyName = "effects")]
        public Link<Page<EffectResponse>> Effects { get; private set; }

        /// <summary>
        /// This endpoint represents precedes that occurred as a result of a given operation.
        /// </summary>
        [JsonProperty(PropertyName = "precedes")]
        public Link<OperationResponse> Precedes { get; private set; }

        /// <summary>
        /// This endpoint represents self that occurred as a result of a given operation.
        /// </summary>
        [JsonProperty(PropertyName = "self")]
        public Link<OperationResponse> Self { get; private set; }

        /// <summary>
        /// This endpoint represents succeeds that occurred as a result of a given operation.
        /// </summary>
        [JsonProperty(PropertyName = "succeeds")]
        public Link<OperationResponse> Succeeds { get; private set; }

        /// <summary>
        /// This endpoint represents transaction that occurred as a result of a given operation.
        /// </summary>
        [JsonProperty(PropertyName = "transaction")]
        public Link<TransactionResponse> Transaction { get; private set; }

        public OperationResponseLinks()
        {

        }

        /// <summary>
        /// Creates an OperationsResponseLinks object type.
        /// </summary>
        /// <param name="effects">This endpoint represents effects that occurred as a result of a given operation.</param>
        /// <param name="precedes">This endpoint represents precedes that occurred as a result of a given operation.</param>
        /// <param name="self">This endpoint represents self that occurred as a result of a given operation.</param>
        /// <param name="succeeds">This endpoint represents succeeds that occurred as a result of a given operation.</param>
        /// <param name="transaction">This endpoint represents transaction that occurred as a result of a given operation.</param>
        public OperationResponseLinks(Link<Page<EffectResponse>> effects, Link<OperationResponse> precedes,
            Link<OperationResponse> self, Link<OperationResponse> succeeds, Link<TransactionResponse> transaction)
        {
            Effects = effects;
            Precedes = precedes;
            Self = self;
            Succeeds = succeeds;
            Transaction = transaction;
        }
    }
}
