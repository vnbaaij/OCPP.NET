namespace OCPP.V16.SmartCharging
{



    public partial class ClearChargingProfileResponse : ResponseBase<ClearChargingProfileRequest, ClearChargingProfileResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ClearChargingProfileResponseStatus Status { get; set; }

         /// <summary>
        /// Create a ClearChargingProfile response.
        /// </summary>
        /// <param name="request">The ClearChargingProfile request leading to this response.</param>
        /// <param name="result">The result.</param>
        public ClearChargingProfileResponse(ClearChargingProfileRequest request) : base(request)
        {
        }
    }
}