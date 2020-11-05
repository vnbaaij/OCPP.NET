namespace OCPP.V16.RemoteTrigger
{



    public partial class TriggerMessageResponse : ResponseBase<TriggerMessageRequest, TriggerMessageResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TriggerMessageResponseStatus Status { get; set; }

         /// <summary>
        /// Create a TriggerMessage response.
        /// </summary>
        /// <param name="request">The TriggerMessage request leading to this response.</param>
        /// <param name="result">The result.</param>
        public TriggerMessageResponse(TriggerMessageRequest request, Result result) : base(request, result)
        {

        }
    }
}