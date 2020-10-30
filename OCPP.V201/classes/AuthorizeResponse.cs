namespace OCPP.V201
{
    public partial class AuthorizeResponse
    {
        //[Newtonsoft.Json.JsonProperty("idTokenInfo", Required = Newtonsoft.Json.Required.Always)]
        public IdTokenInfo IdTokenInfo { get; set; } = new IdTokenInfo();

        //[Newtonsoft.Json.JsonProperty("certificateStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AuthorizeCertificateStatus CertificateStatus { get; set; }


    }
}