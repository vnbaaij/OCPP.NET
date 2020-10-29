namespace OCPP
{
    /// <summary>Contains the identifier to use for authorization.
    /// </summary>

    public partial class AuthorizationData
    {
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdToken IdToken { get; set; } = new IdToken();

        //[Newtonsoft.Json.JsonProperty("idTokenInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenInfo IdTokenInfo { get; set; }
    }
}