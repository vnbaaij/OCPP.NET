namespace OCPP.V201.V201
{
    /// <summary>
    /// Contains a case insensitive identifier to use for the authorization and the  of authorization to support multiple forms of identifiers.
    /// </summary>

    public partial class IdToken 
    {
        //[Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalInfo> AdditionalInfo { get; set; }
    
        /// <summary>
        /// IdToken is case insensitive. Might hold the hidden id of an RFID tag, but can for example also contain a UUID.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public string IdTokenValue { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IdToken Type { get; set; }
    }
}