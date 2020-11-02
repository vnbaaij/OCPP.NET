using OCPP.Core;

namespace OCPP.V201
{
    public partial class RequestStartTransactionRequest : RequestBase<RequestStartTransactionRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        /// <summary>Number of the EVSE on which to start the transaction. EvseId SHALL be &amp;gt; 0
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }

        //[Newtonsoft.Json.JsonProperty("groupIdToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdToken GroupIdToken { get; set; }

        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdToken IdToken { get; set; } = new IdToken();

        /// <summary>Id given by the server to this start request. The Charging Station might return this in the &amp;lt;&amp;lt;transactioneventrequest, TransactionEventRequest&amp;gt;&amp;gt;, letting the server know which transaction was started for this request. Use to start a transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("remoteStartId", Required = Newtonsoft.Json.Required.Always)]
        public int RemoteStartId { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingProfile", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChargingProfile ChargingProfile { get; set; }
    }
}