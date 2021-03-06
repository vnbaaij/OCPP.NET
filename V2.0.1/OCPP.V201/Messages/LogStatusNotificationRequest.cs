using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class LogStatusNotificationRequest : RequestBase<LogStatusNotificationRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UploadLogStatus Status { get; set; }
    
        /// <summary>The request id that was provided in GetLogRequest that started this log upload. This field is mandatory,
        /// unless the message was triggered by a TriggerMessageRequest AND there is no log upload ongoing.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RequestId { get; set; }
    }
}