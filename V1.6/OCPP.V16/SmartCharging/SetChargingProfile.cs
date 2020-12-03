using OCPP.V16.Core;

namespace OCPP.V16.SmartCharging
{
    public record SetChargingProfileRequest : RequestBase<SetChargingProfileRequest>
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }

        //[Newtonsoft.Json.JsonProperty("csChargingProfiles", Required = Newtonsoft.Json.Required.Always)]
        public ChargingProfile CsChargingProfiles { get; set; } = new ChargingProfile();


    }
}