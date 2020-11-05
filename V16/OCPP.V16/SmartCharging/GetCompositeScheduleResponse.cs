using OCPP.V16.Core;

namespace OCPP.V16.SmartCharging
{



    public partial class GetCompositeScheduleResponse : ResponseBase<GetCompositeScheduleRequest, GetCompositeScheduleResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetCompositeScheduleResponseStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConnectorId { get; set; }

        //[Newtonsoft.Json.JsonProperty("scheduleStart", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ScheduleStart { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingSchedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChargingSchedule ChargingSchedule { get; set; }

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <param name="request">The request leading to this response.</param>
        /// <param name="result">The result.</param>
        public GetCompositeScheduleResponse(GetCompositeScheduleRequest request, Result result) : base(request, result)
        {

        }
    }
}