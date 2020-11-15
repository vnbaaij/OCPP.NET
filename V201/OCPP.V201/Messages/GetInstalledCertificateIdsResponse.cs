using OCPP.V201.Core;

namespace OCPP.V201
{


    public partial class GetInstalledCertificateIdsResponse : ResponseBase<GetInstalledCertificateIdsRequest, GetInstalledCertificateIdsResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetInstalledCertificateStatus Status { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("certificateHashDataChain", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CertificateHashDataChain> CertificateHashDataChain { get; set; }

        /// <summary>
        /// Create an get installed certificate ids response.
        /// </summary>
        /// <param name="request">The get installed certificate ids request leading to this response.</param>
        /// <param name="result">The result.</param>
        public GetInstalledCertificateIdsResponse(GetInstalledCertificateIdsRequest request, Result result) : base(request, result)
        {

        }
    }
}