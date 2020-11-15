using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class BootNotificationRequest : RequestBase<BootNotificationRequest>
    {

        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        //[Newtonsoft.Json.JsonProperty("chargingStation", Required = Newtonsoft.Json.Required.Always)]
        public ChargingStation ChargingStation { get; set; } = new ChargingStation();

        //[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BootReason Reason { get; set; }


    }
}