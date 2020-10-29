namespace OCPP
{
    public partial class ChargingLimit 
    {
        //[Newtonsoft.Json.JsonProperty("chargingLimitSource", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingLimitSource ChargingLimitSource { get; set; }
    
        /// <summary>Charging_ Limit. Is_ Grid_ Critical. Indicator
        /// urn:x-enexis:ecdm:uid:1:570847
        /// Indicates whether the charging limit is critical for the grid.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("isGridCritical", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsGridCritical { get; set; }
    }
}