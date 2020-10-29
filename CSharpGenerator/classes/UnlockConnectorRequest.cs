namespace OCPP
{public partial class UnlockConnectorRequest
    {
        /// <summary>This contains the identifier of the EVSE for which a connector needs to be unlocked.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    
        /// <summary>This contains the identifier of the connector that needs to be unlocked.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    }
}