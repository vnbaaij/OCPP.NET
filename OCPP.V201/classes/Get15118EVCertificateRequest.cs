namespace OCPP.V201
{

    public partial class Get15118EVCertificateRequest
    {
        /// <summary>Schema version currently used for the 15118 session between EV and Charging Station. Needed for parsing of the EXI stream by the CSMS.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("iso15118SchemaVersion", Required = Newtonsoft.Json.Required.Always)]
        public string Iso15118SchemaVersion { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CertificateAction Action { get; set; }
    
        /// <summary>Raw CertificateInstallationReq request from EV, Base64 encoded.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("exiRequest", Required = Newtonsoft.Json.Required.Always)]
        public string ExiRequest { get; set; }
    }
}