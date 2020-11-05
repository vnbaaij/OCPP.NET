namespace OCPP.V16.Core
{



    public partial class ChangeAvailabilityResponse : ResponseBase<ChangeAvailabilityRequest, ChangeAvailabilityResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChangeAvailabilityResponseStatus Status
        {
            get; set;
        }
        
        /// <summary>
         /// Create a response.
         /// </summary>
         /// <param name="request">The request leading to this response.</param>
         /// <param name="result">The result.</param>
        public ChangeAvailabilityResponse(ChangeAvailabilityRequest request, Result result) : base(request, result)
        {

        }
    }
}
