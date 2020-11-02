using OCPP.Core;

namespace OCPP.V201
{
    public partial class CustomerInformationResponse : ResponseBase<CustomerInformationRequest,CustomerInformationResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CustomerInformationStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }

        public CustomerInformationResponse(CustomerInformationRequest request,Result result)  : base(request, result)
        {

        }
    }
}