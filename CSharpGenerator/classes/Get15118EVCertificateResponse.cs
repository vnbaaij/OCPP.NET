namespace OCPP
{
    public partial class Get15118EVCertificateResponse
    {
        
    
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Iso15118EVCertificateStatus Status { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }
    
        /// <summary>Raw CertificateInstallationRes response for the EV, Base64 encoded.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("exiResponse", Required = Newtonsoft.Json.Required.Always)]
        public string ExiResponse { get; set; }
    
    
    }
}