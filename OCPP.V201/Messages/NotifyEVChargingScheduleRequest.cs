using OCPP.Core;

namespace OCPP.V201
{
    public partial class NotifyEVChargingScheduleRequest : RequestBase<NotifyEVChargingScheduleRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        /// <summary>Periods contained in the charging profile are relative to this point in time.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timeBase", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset TimeBase { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingSchedule", Required = Newtonsoft.Json.Required.Always)]
        public ChargingSchedule ChargingSchedule { get; set; } = new ChargingSchedule();

        /// <summary>The charging schedule contained in this notification applies to an EVSE. EvseId must be &amp;gt; 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    }
}