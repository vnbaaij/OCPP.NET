namespace OCPP.V16.Core
{



    public partial class ChangeAvailabilityResponse : ResponseBase<ChangeAvailabilityRequest, ChangeAvailabilityResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AvailabilityStatus Status
        {
            get; set;
        }
        
         /// <summary>
        /// Create a ChangeAvailability response.
        /// </summary>
        /// <param name="request">The ChangeAvailability request leading to this response.</param>
        /// <param name="result">The result.</param>
        public ChangeAvailabilityResponse(ChangeAvailabilityRequest request) : base(request)
        {

        }
    }
}
