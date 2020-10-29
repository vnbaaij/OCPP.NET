namespace OCPP
{

    public partial class FirmwareStatusNotificationRequest
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FirmwareStatus Status { get; set; }
    
        /// <summary>The request id that was provided in the
        /// UpdateFirmwareRequest that started this firmware update.
        /// This field is mandatory, unless the message was triggered by a TriggerMessageRequest AND there is no firmware update ongoing.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RequestId { get; set; }
    }
}