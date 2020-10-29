namespace OCPP
{
    /// <summary>Charging_ Needs
    /// urn:x-oca:ocpp:uid:2:233249
    /// </summary>

    public partial class ChargingNeeds 
    {
        //[Newtonsoft.Json.JsonProperty("acChargingParameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ACChargingParameters AcChargingParameters { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("dcChargingParameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DCChargingParameters DcChargingParameters { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("requestedEnergyTransfer", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EnergyTransferMode RequestedEnergyTransfer { get; set; }
    
        /// <summary>Charging_ Needs. Departure_ Time. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569223
        /// Estimated departure time of the EV.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("departureTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset DepartureTime { get; set; }
    }
}