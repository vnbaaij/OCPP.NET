namespace OCPP
{
    /// <summary>Represents a UnitOfMeasure with a multiplier
    /// </summary>

    public partial class UnitOfMeasure
    {


        /// <summary>Unit of the value. Default = "Wh" if the (default) measurand is an "Energy" .
        /// This field SHALL use a value from the list Standardized Units of Measurements in Part 2 Appendices.
        /// If an applicable unit is available in that list, otherwise a "custom" unit might be used.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit { get; set; } = "Wh";

        /// <summary>Multiplier, this value represents the exponent to base 10. I.e. multiplier 3 means 10 raised to the 3rd power. Default is 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("multiplier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Multiplier { get; set; } = 0;


    }
}