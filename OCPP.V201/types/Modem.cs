namespace OCPP
{
    /// <summary>Wireless_ Communication_ Module
    /// urn:x-oca:ocpp:uid:2:233306
    /// Defines parameters required for initiating and maintaining wireless communication with other devices.
    /// </summary>

    public partial class Modem 
    {
        /// <summary>Wireless_ Communication_ Module. ICCID. CI20_ Text
        /// urn:x-oca:ocpp:uid:1:569327
        /// This contains the ICCID of the modem’s SIM card.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("iccid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Iccid { get; set; }
    
        /// <summary>Wireless_ Communication_ Module. IMSI. CI20_ Text
        /// urn:x-oca:ocpp:uid:1:569328
        /// This contains the IMSI of the modem’s SIM card.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("imsi", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Imsi { get; set; }
    }
}