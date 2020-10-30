namespace OCPP.V201
{
    /// <summary>DC_ Charging_ Parameters
    /// urn:x-oca:ocpp:uid:2:233251
    /// EV DC charging parameters
    /// 
    /// 
    /// </summary>

    public partial class DCChargingParameters 
    {
        /// <summary>DC_ Charging_ Parameters. EV_ Max. Current
        /// urn:x-oca:ocpp:uid:1:569215
        /// Maximum current (amps) supported by the electric vehicle. Includes cable capacity.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evMaxCurrent", Required = Newtonsoft.Json.Required.Always)]
        public int EvMaxCurrent { get; set; }
    
        /// <summary>DC_ Charging_ Parameters. EV_ Max. Voltage
        /// urn:x-oca:ocpp:uid:1:569216
        /// Maximum voltage supported by the electric vehicle
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evMaxVoltage", Required = Newtonsoft.Json.Required.Always)]
        public int EvMaxVoltage { get; set; }
    
        /// <summary>DC_ Charging_ Parameters. Energy_ Amount. Energy_ Amount
        /// urn:x-oca:ocpp:uid:1:569217
        /// Amount of energy requested (in Wh). This inludes energy required for preconditioning.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("energyAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EnergyAmount { get; set; }
    
        /// <summary>DC_ Charging_ Parameters. EV_ Max. Power
        /// urn:x-oca:ocpp:uid:1:569218
        /// Maximum power (in W) supported by the electric vehicle. Required for DC charging.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evMaxPower", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvMaxPower { get; set; }
    
        /// <summary>DC_ Charging_ Parameters. State_ Of_ Charge. Numeric
        /// urn:x-oca:ocpp:uid:1:569219
        /// Energy available in the battery (in percent of the battery capacity)
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("stateOfCharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StateOfCharge { get; set; }
    
        /// <summary>DC_ Charging_ Parameters. EV_ Energy_ Capacity. Numeric
        /// urn:x-oca:ocpp:uid:1:569220
        /// Capacity of the electric vehicle battery (in Wh)
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evEnergyCapacity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvEnergyCapacity { get; set; }
    
        /// <summary>DC_ Charging_ Parameters. Full_ SOC. Percentage
        /// urn:x-oca:ocpp:uid:1:569221
        /// Percentage of SoC at which the EV considers the battery fully charged. (possible values: 0 - 100)
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("fullSoC", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int FullSoC { get; set; }
    
        /// <summary>DC_ Charging_ Parameters. Bulk_ SOC. Percentage
        /// urn:x-oca:ocpp:uid:1:569222
        /// Percentage of SoC at which the EV considers a fast charging process to end. (possible values: 0 - 100)
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("bulkSoC", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int BulkSoC { get; set; }
    }
}