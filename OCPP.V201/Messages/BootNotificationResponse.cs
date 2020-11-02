using OCPP.Core;

namespace OCPP.V201
{
    public partial class BootNotificationResponse : ResponseBase<BootNotificationRequest,BootNotificationResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        /// <summary>This contains the CSMS’s current time.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("currentTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset CurrentTime { get; set; }

        /// <summary>When &amp;lt;&amp;lt;cmn_registrationstatus,Status&amp;gt;&amp;gt; is Accepted, this contains the heartbeat interval in seconds. If the CSMS returns something other than Accepted, the value of the interval field indicates the minimum wait time before sending a next BootNotification request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.Always)]
        public int Interval { get; set; }

        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RegistrationStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }

        /// <summary>
        /// Create an boot notification response.
        /// </summary>
        /// <param name="request">The boot notification request leading to this response.</param>
        /// <param name="result">The result.</param>
        public BootNotificationResponse(BootNotificationRequest request, Result result) : base(request, result)
        {
            
        }
    }
}