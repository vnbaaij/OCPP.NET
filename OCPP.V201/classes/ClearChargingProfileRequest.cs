namespace OCPP
{
    public partial class ClearChargingProfileRequest
    {


        /// <summary>The Id of the charging profile to clear.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("chargingProfileId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ChargingProfileId { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingProfileCriteria", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ClearChargingProfile ChargingProfileCriteria { get; set; }


    }
}