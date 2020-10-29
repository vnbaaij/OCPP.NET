namespace OCPP
{
    /// <summary>Cost
    /// urn:x-oca:ocpp:uid:2:233258
    /// </summary>

    public partial class Cost 
    {
        
    
        //[Newtonsoft.Json.JsonProperty("costKind", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CostKind CostKind { get; set; }
    
        /// <summary>Cost. Amount. Amount
        /// urn:x-oca:ocpp:uid:1:569244
        /// The estimated or actual cost per kWh
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public int Amount { get; set; }
    
        /// <summary>Cost. Amount_ Multiplier. Integer
        /// urn:x-oca:ocpp:uid:1:569245
        /// Values: -3..3, The amountMultiplier defines the exponent to base 10 (dec). The final value is determined by: amount * 10 ^ amountMultiplier
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("amountMultiplier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int AmountMultiplier { get; set; }
    
    
    }
}