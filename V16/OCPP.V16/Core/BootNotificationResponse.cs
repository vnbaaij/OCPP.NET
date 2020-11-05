using System;

namespace OCPP.V16.Core
{
    public partial class BootNotificationResponse : ResponseBase<BootNotificationRequest, BootNotificationResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        ////[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BootNotificationResponseStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("currentTime", Required = Newtonsoft.Json.Required.Always)]
        public DateTime CurrentTime { get; set; }

        //[Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.Always)]
        public int Interval { get; set; }

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