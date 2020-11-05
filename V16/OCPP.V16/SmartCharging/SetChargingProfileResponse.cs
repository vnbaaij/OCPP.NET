namespace OCPP.V16.SmartCharging
{



    public partial class SetChargingProfileResponse : ResponseBase<SetChargingProfileRequest, SetChargingProfileResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetChargingProfileResponseStatus Status { get; set; }
        
        /// <summary>
        /// Create a response.
        /// </summary>
        /// <param name="request">The request leading to this response.</param>
        /// <param name="result">The result.</param>
        public SetChargingProfileResponse(SetChargingProfileRequest request, Result result) : base(request, result)
        {

        }
    }
}
