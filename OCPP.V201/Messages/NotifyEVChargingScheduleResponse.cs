using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class NotifyEVChargingScheduleResponse : ResponseBase<NotifyEVChargingScheduleRequest, NotifyEVChargingScheduleResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GenericStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }
        public NotifyEVChargingScheduleResponse(NotifyEVChargingScheduleRequest request, Result result) : base(request, result)
        {

        }

    }
}