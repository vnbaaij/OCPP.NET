using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class NotifyEVChargingNeedsRequest : RequestBase<NotifyEVChargingNeedsRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        /// <summary>Contains the maximum schedule tuples the car supports per schedule.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("maxScheduleTuples", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int MaxScheduleTuples { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingNeeds", Required = Newtonsoft.Json.Required.Always)]
        public ChargingNeeds ChargingNeeds { get; set; } = new ChargingNeeds();

        /// <summary>Defines the EVSE and connector to which the EV is connected. EvseId may not be 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    }
}