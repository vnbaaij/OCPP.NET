namespace OCPP.V201
{
    /// <summary>Consumption_ Cost
    /// urn:x-oca:ocpp:uid:2:233259
    /// </summary>

    public partial class ConsumptionCost 
    {
        /// <summary>Consumption_ Cost. Start_ Value. Numeric
        /// urn:x-oca:ocpp:uid:1:569246
        /// The lowest level of consumption that defines the starting point of this consumption block. The block interval extends to the start of the next interval.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("startValue", Required = Newtonsoft.Json.Required.Always)]
        public double StartValue { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<Cost> Cost { get; set; } = new System.Collections.ObjectModel.Collection<Cost>();
    }
}