namespace OCPP
{
    
    /// <summary>Request_ Body
    /// urn:x-enexis:ecdm:uid:2:234744
    /// </summary>
    
    public partial class MeterValuesRequest
    {
        
    
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