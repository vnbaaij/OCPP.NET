using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class TransactionEventResponse : ResponseBase<TransactionEventRequest,TransactionEventResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>SHALL only be sent when charging has ended. Final total cost of this transaction, including taxes. In the currency configured with the Configuration Variable: &amp;lt;&amp;lt;configkey-currency,`Currency`&amp;gt;&amp;gt;. When omitted, the transaction was NOT free. To indicate a free transaction, the CSMS SHALL send 0.00.
        ///
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("totalCost", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalCost { get; set; }

        /// <summary>Priority from a business point of view. Default priority is 0, The range is from -9 to 9. Higher values indicate a higher priority. The chargingPriority in &amp;lt;&amp;lt;transactioneventresponse,TransactionEventResponse&amp;gt;&amp;gt; is temporarily, so it may not be set in the &amp;lt;&amp;lt;cmn_idtokeninfo,IdTokenInfo&amp;gt;&amp;gt; afterwards. Also the chargingPriority in &amp;lt;&amp;lt;transactioneventresponse,TransactionEventResponse&amp;gt;&amp;gt; overrules the one in &amp;lt;&amp;lt;cmn_idtokeninfo,IdTokenInfo&amp;gt;&amp;gt;.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("chargingPriority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ChargingPriority { get; set; }

        //[Newtonsoft.Json.JsonProperty("idTokenInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenInfo IdTokenInfo { get; set; }

        //[Newtonsoft.Json.JsonProperty("updatedPersonalMessage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MessageContent UpdatedPersonalMessage { get; set; }

        public TransactionEventResponse(TransactionEventRequest request,Result result)  : base(request, result)
        {

        }
    }
}