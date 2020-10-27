using OCPP.Core;

namespace OCPP.SmartCharging
{



    public partial class GetCompositeScheduleResponse
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
    }
}