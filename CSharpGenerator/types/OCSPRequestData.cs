namespace OCPP
{//public partial class CustomData 
    //{
    //    //[Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
    //    public string VendorId { get; set; }

    //    private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

    //    //[Newtonsoft.Json.JsonExtensionData]
    //    public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
    //    {
    //        get { return _additionalProperties; }
    //        set { _additionalProperties = value; }
    //    }


    //}

    /// <summary>Contains a case insensitive identifier to use for the authorization and the  of authorization to support multiple forms of identifiers.
    /// </summary>

    //public partial class AdditionalInfo 
    //{
    //    //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    //    public CustomData CustomData { get; set; }

    //    /// <summary>This field specifies the additional IdToken.
    //    /// </summary>
    //    //[Newtonsoft.Json.JsonProperty("additionalIdToken", Required = Newtonsoft.Json.Required.Always)]
    //    public string AdditionalIdToken { get; set; }

    //    /// <summary>This defines the  of the additionalIdToken. This is a custom , so the implementation needs to be agreed upon by all involved parties.
    //    /// </summary>
    //    //[Newtonsoft.Json.JsonProperty("", Required = Newtonsoft.Json.Required.Always)]
    //    public string  { get; set; }


    //}



    public partial class OCSPRequestData 
    {
        
    
        //[Newtonsoft.Json.JsonProperty("hashAlgorithm", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HashAlgorithm HashAlgorithm { get; set; }
    
        /// <summary>Hashed value of the Issuer DN (Distinguished Name).
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("issuerNameHash", Required = Newtonsoft.Json.Required.Always)]
        public string IssuerNameHash { get; set; }
    
        /// <summary>Hashed value of the issuers public key
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("issuerKeyHash", Required = Newtonsoft.Json.Required.Always)]
        public string IssuerKeyHash { get; set; }
    
        /// <summary>The serial number of the certificate.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("serialNumber", Required = Newtonsoft.Json.Required.Always)]
        public string SerialNumber { get; set; }
    
        /// <summary>This contains the responder URL (Case insensitive). 
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("responderURL", Required = Newtonsoft.Json.Required.Always)]
        public string ResponderURL { get; set; }
    
    
    }
}