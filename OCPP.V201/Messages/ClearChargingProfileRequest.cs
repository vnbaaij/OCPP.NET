using OCPP.Core;

namespace OCPP.V201
{
    public partial class ClearChargingProfileRequest : RequestBase<ClearChargingProfileRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        /// <summary>The Id of the charging profile to clear.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("chargingProfileId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ChargingProfileId { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargingProfileCriteria", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ClearChargingProfile ChargingProfileCriteria { get; set; }


    }
}