using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class MeterValuesRequest : RequestBase<MeterValuesRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Request_ Body. EVSEID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:571101
        /// This contains a number (&amp;gt;0) designating an EVSE of the Charging Station. ‘0’ (zero) is used to designate the main power meter.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("meterValue", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<MeterValue> MeterValue { get; set; } = new System.Collections.ObjectModel.Collection<MeterValue>();
    }
}