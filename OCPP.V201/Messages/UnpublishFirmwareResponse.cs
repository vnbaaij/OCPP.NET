using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class UnpublishFirmwareResponse : ResponseBase<UnpublishFirmwareRequest, UnpublishFirmwareResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UnpublishFirmwareStatus Status { get; set; }

        public UnpublishFirmwareResponse(UnpublishFirmwareRequest request, Result result) : base(request, result)
        {

        }
    }
}