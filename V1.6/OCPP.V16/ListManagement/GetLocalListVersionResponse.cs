namespace OCPP.V16.ListManagement
{

    public partial class GetLocalListVersionResponse : ResponseBase<GetLocalListVersionResponse>
    {
        //[Newtonsoft.Json.JsonProperty("listVersion", Required = Newtonsoft.Json.Required.Always)]
        public int ListVersion { get; set; }

         /// <summary>
        /// Create a GetLocalListVersion response.
        /// </summary>
        /// <param name="request">The GetLocalListVersion request leading to this response.</param>
        /// <param name="result">The result.</param>
        public GetLocalListVersionResponse() : base()
        {

        }
    }
}
