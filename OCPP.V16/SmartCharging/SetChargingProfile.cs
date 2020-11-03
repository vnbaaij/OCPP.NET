using OCPP.V16;

namespace OCPP.V16.SmartCharging
{
    public partial class SetChargingProfileRequest : RequestBase<SetChargingProfileRequest>
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }

        //[Newtonsoft.Json.JsonProperty("csChargingProfiles", Required = Newtonsoft.Json.Required.Always)]
        public CsChargingProfiles CsChargingProfiles { get; set; } = new CsChargingProfiles();


    }
}