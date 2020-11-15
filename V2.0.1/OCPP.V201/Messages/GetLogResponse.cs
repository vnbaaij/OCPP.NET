using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class GetLogResponse : ResponseBase<GetLogRequest, GetLogResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LogStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }

        /// <summary>This contains the name of the log file that will be uploaded. This field is not present when no logging information is available.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("filename", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Filename { get; set; }

        public GetLogResponse(GetLogRequest request, Result result) : base(request, result)
        {

        }
    }
}