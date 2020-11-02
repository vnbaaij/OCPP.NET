using OCPP.Core;

namespace OCPP.V201
{
    public partial class GetCompositeScheduleRequest : RequestBase<GetCompositeScheduleRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Length of the requested schedule in seconds.
        ///
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingRateUnit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingRateUnit ChargingRateUnit { get; set; }

        /// <summary>The ID of the EVSE for which the schedule is requested. When evseid=0, the Charging Station will calculate the expected consumption for the grid connection.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    }
}