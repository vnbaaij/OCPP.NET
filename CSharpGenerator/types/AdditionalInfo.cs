namespace OCPP
{
    /// <summary>
    /// Contains a case insensitive identifier to use for the authorization and the  of authorization to support multiple forms of identifiers.
    /// </summary>

    public partial class AdditionalInfo
    {
        /// <summary>
        /// This field specifies the additional IdToken.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("additionalIdToken", Required = Newtonsoft.Json.Required.Always)]
        public string AdditionalIdToken { get; set; }

        /// <summary>
        /// This defines the  of the additionalIdToken. This is a custom , so the implementation needs to be agreed upon by all involved parties.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("", Required = Newtonsoft.Json.Required.Always)]
        public string Type { get; set; }
    }
}