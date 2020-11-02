using OCPP.Core;

namespace OCPP.V201
{
    public partial class CostUpdatedRequest : RequestBase<CostUpdatedRequest>    
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Current total cost, based on the information known by the CSMS, of the transaction including taxes. In the currency configured with the configuration Variable: [&amp;lt;&amp;lt;configkey-currency, Currency&amp;gt;&amp;gt;]
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("totalCost", Required = Newtonsoft.Json.Required.Always)]
        public double TotalCost { get; set; }
    
        /// <summary>Transaction Id of the transaction the current cost are asked for.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public string TransactionId { get; set; }
    }
}