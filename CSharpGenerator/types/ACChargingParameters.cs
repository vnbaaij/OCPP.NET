namespace OCPP
{
    /// <summary>AC_ Charging_ Parameters
    /// urn:x-oca:ocpp:uid:2:233250
    /// EV AC charging parameters.
    /// 
    /// </summary>

    public partial class ACChargingParameters 
    {
        
    
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
}