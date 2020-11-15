using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class GetLocalListVersionResponse : ResponseBase<GetLocalListVersionRequest, GetLocalListVersionResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>This contains the current version number of the local authorization list in the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("versionNumber", Required = Newtonsoft.Json.Required.Always)]
        public int VersionNumber { get; set; }

        /// <summary>
        /// Create an get installed certificate ids response.
        /// </summary>
        /// <param name="request">The get installed certificate ids request leading to this response.</param>
        /// <param name="result">The result.</param>
        public GetLocalListVersionResponse(GetLocalListVersionRequest request, Result result) : base(request, result)
        {

        }
    }
}