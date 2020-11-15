namespace OCPP.V201
{
    /// <summary>Transaction
    /// urn:x-oca:ocpp:uid:2:233318
    /// </summary>

    public partial class Transaction
    {
        /// <summary>This contains the Id of the transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public string TransactionId { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingState", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingState ChargingState { get; set; }

        /// <summary>Transaction. Time_ Spent_ Charging. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569415
        /// Contains the total time that energy flowed from EVSE to EV during the transaction (in seconds). Note that timeSpentCharging is smaller or equal to the duration of the transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timeSpentCharging", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TimeSpentCharging { get; set; }

        //[Newtonsoft.Json.JsonProperty("stoppedReason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Reason StoppedReason { get; set; }

        /// <summary>The ID given to remote start request (&amp;lt;&amp;lt;requeststarttransactionrequest, RequestStartTransactionRequest&amp;gt;&amp;gt;. This enables to CSMS to match the started transaction to the given start request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("remoteStartId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RemoteStartId { get; set; }
    }
}