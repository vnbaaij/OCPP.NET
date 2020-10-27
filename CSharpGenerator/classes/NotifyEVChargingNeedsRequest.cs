





namespace OCPP
{
    #pragma warning disable // Disable all warnings

    /// <summary>This class does not get 'AdditionalProperties = false' in the schema generation, so it can be extended with arbitrary JSON properties to allow adding custom data.</summary>
    
    public partial class CustomDataType 
    {
        //[Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        //[Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>Charging_ Needs. Requested. Energy_ Transfer_ Mode_ Code
    /// urn:x-oca:ocpp:uid:1:569209
    /// Mode of energy transfer requested by the EV.
    /// </summary>
    
    public enum EnergyTransferModeEnumType
    {
        
        DC = 0,
    
        
        AC_single_phase = 1,
    
        
        AC_two_phase = 2,
    
        
        AC_three_phase = 3,
    
    }
    
    /// <summary>AC_ Charging_ Parameters
    /// urn:x-oca:ocpp:uid:2:233250
    /// EV AC charging parameters.
    /// 
    /// </summary>
    
    public partial class ACChargingParametersType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>AC_ Charging_ Parameters. Energy_ Amount. Energy_ Amount
        /// urn:x-oca:ocpp:uid:1:569211
        /// Amount of energy requested (in Wh). This includes energy required for preconditioning.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("energyAmount", Required = Newtonsoft.Json.Required.Always)]
        public int EnergyAmount { get; set; }
    
        /// <summary>AC_ Charging_ Parameters. EV_ Min. Current
        /// urn:x-oca:ocpp:uid:1:569212
        /// Minimum current (amps) supported by the electric vehicle (per phase).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evMinCurrent", Required = Newtonsoft.Json.Required.Always)]
        public int EvMinCurrent { get; set; }
    
        /// <summary>AC_ Charging_ Parameters. EV_ Max. Current
        /// urn:x-oca:ocpp:uid:1:569213
        /// Maximum current (amps) supported by the electric vehicle (per phase). Includes cable capacity.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evMaxCurrent", Required = Newtonsoft.Json.Required.Always)]
        public int EvMaxCurrent { get; set; }
    
        /// <summary>AC_ Charging_ Parameters. EV_ Max. Voltage
        /// urn:x-oca:ocpp:uid:1:569214
        /// Maximum voltage supported by the electric vehicle
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evMaxVoltage", Required = Newtonsoft.Json.Required.Always)]
        public int EvMaxVoltage { get; set; }
    
    
    }
    
    /// <summary>Charging_ Needs
    /// urn:x-oca:ocpp:uid:2:233249
    /// </summary>
    
    public partial class ChargingNeedsType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("acChargingParameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ACChargingParametersType AcChargingParameters { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("dcChargingParameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DCChargingParametersType DcChargingParameters { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("requestedEnergyTransfer", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EnergyTransferModeEnumType RequestedEnergyTransfer { get; set; }
    
        /// <summary>Charging_ Needs. Departure_ Time. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569223
        /// Estimated departure time of the EV.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("departureTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset DepartureTime { get; set; }
    
    
    }
    
    /// <summary>DC_ Charging_ Parameters
    /// urn:x-oca:ocpp:uid:2:233251
    /// EV DC charging parameters
    /// 
    /// 
    /// </summary>
    
    public partial class DCChargingParametersType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
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
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Contains the maximum schedule tuples the car supports per schedule.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("maxScheduleTuples", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int MaxScheduleTuples { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingNeeds", Required = Newtonsoft.Json.Required.Always)]
        public ChargingNeedsType ChargingNeeds { get; set; } = new ChargingNeedsType();
    
        /// <summary>Defines the EVSE and connector to which the EV is connected. EvseId may not be 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    
    
    }
}