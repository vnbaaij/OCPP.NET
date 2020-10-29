namespace OCPP
{
    /// <summary>Sales_ Tariff_ Entry
    /// urn:x-oca:ocpp:uid:2:233271
    /// </summary>

    public partial class SalesTariffEntry 
    {
        
    
        //[Newtonsoft.Json.JsonProperty("relativeTimeInterval", Required = Newtonsoft.Json.Required.Always)]
        public RelativeTimeInterval RelativeTimeInterval { get; set; } = new RelativeTimeInterval();
    
        /// <summary>Sales_ Tariff_ Entry. E_ Price_ Level. Unsigned_ Integer
        /// urn:x-oca:ocpp:uid:1:569281
        /// Defines the price level of this SalesTariffEntry (referring to NumEPriceLevels). Small values for the EPriceLevel represent a cheaper TariffEntry. Large values for the EPriceLevel represent a more expensive TariffEntry.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("ePriceLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EPriceLevel { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("consumptionCost", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ConsumptionCost> ConsumptionCost { get; set; }
    
    
    }
}