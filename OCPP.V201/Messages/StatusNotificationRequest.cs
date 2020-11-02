using OCPP.Core;

namespace OCPP.V201
{
    public partial class StatusNotificationRequest : RequestBase<StatusNotificationRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>The time for which the status is reported. If absent time of receipt of the message will be assumed.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("connectorStatus", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ConnectorStatus ConnectorStatus { get; set; }
    
        /// <summary>The id of the EVSE to which the connector belongs for which the the status is reported.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    
        /// <summary>The id of the connector within the EVSE for which the status is reported.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    }
}