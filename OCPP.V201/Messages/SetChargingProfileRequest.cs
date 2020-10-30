namespace OCPP.V201
{
    public partial class SetChargingProfileRequest
    {
        /// <summary>For TxDefaultProfile an evseId=0 applies the profile to each individual evse. For ChargingStationMaxProfile and ChargingStationExternalConstraints an evseId=0 contains an overal limit for the whole Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingProfile", Required = Newtonsoft.Json.Required.Always)]
        public ChargingProfile ChargingProfile { get; set; } = new ChargingProfile();
    }
}