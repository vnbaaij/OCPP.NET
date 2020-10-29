namespace OCPP
{
    public partial class CustomerInformationRequest
    {
        //[Newtonsoft.Json.JsonProperty("customerCertificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CertificateHashData CustomerCertificate { get; set; }

        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdToken IdToken { get; set; }

        /// <summary>The Id of the request.
        ///
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }

        /// <summary>Flag indicating whether the Charging Station should return NotifyCustomerInformationRequest messages containing information about the customer referred to.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("report", Required = Newtonsoft.Json.Required.Always)]
        public bool Report { get; set; }

        /// <summary>Flag indicating whether the Charging Station should clear all information about the customer referred to.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("clear", Required = Newtonsoft.Json.Required.Always)]
        public bool Clear { get; set; }

        /// <summary>A (e.g. vendor specific) identifier of the customer this request refers to. This field contains a custom identifier other than IdToken and Certificate.
        /// One of the possible identifiers (customerIdentifier, customerIdToken or customerCertificate) should be in the request message.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("customerIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerIdentifier { get; set; }
    }
}