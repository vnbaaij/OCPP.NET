using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class Get15118EVCertificateResponse : ResponseBase<Get15118EVCertificateRequest,Get15118EVCertificateResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Iso15118EVCertificateStatus Status { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }
    
        /// <summary>Raw CertificateInstallationRes response for the EV, Base64 encoded.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("exiResponse", Required = Newtonsoft.Json.Required.Always)]
        public string ExiResponse { get; set; }

        public Get15118EVCertificateResponse(Get15118EVCertificateRequest request,Result result)  : base(request, result)
        {

        }
    }
}