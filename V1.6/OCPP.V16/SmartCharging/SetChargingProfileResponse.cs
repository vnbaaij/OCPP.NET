namespace OCPP.V16.SmartCharging
{



    public partial class SetChargingProfileResponse : ResponseBase<SetChargingProfileRequest, SetChargingProfileResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfileStatus Status { get; set; }
        
         /// <summary>
        /// Create a SetChargingProfile response.
        /// </summary>
        /// <param name="request">The SetChargingProfile request leading to this response.</param>
        /// <param name="result">The result.</param>
        public SetChargingProfileResponse(SetChargingProfileRequest request) : base(request)
        {

        }
    }
}
