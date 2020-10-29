namespace OCPP
{
    /// <summary>Sales_ Tariff
    /// urn:x-oca:ocpp:uid:2:233272
    /// NOTE: This data is based on datas from &amp;lt;&amp;lt;ref-ISOIEC15118-2,ISO 15118-2&amp;gt;&amp;gt;.
    /// </summary>

    public partial class SalesTariff 
    {
        
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// SalesTariff identifier used to identify one sales tariff. An SAID remains a unique identifier for one schedule throughout a charging session.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Sales_ Tariff. Sales. Tariff_ Description
        /// urn:x-oca:ocpp:uid:1:569283
        /// A human readable title/short description of the sales tariff e.g. for HMI display purposes.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("salesTariffDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesTariffDescription { get; set; }
    
        /// <summary>Sales_ Tariff. Num_ E_ Price_ Levels. Counter
        /// urn:x-oca:ocpp:uid:1:569284
        /// Defines the overall number of distinct price levels used across all provided SalesTariff elements.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("numEPriceLevels", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumEPriceLevels { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("salesTariffEntry", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SalesTariffEntry> SalesTariffEntry { get; set; } = new System.Collections.ObjectModel.Collection<SalesTariffEntry>();
    
    
    }
}