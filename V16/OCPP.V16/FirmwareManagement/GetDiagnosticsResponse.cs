namespace OCPP.V16.FirmwareManagement

{

    public partial class GetDiagnosticsResponse : ResponseBase<GetDiagnosticsRequest, GetDiagnosticsResponse>
    {
        //[Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName { get; set; }

         /// <summary>
        /// Create a GetDiagnostics response.
        /// </summary>
        /// <param name="request">The GetDiagnostics request leading to this response.</param>
        /// <param name="result">The result.</param>
        public GetDiagnosticsResponse(GetDiagnosticsRequest request, Result result) : base(request, result)
        {

        }
    }
}
