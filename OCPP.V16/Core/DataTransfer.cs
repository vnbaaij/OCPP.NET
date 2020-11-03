using OCPP.V16;

namespace OCPP.V16.Core
{
    public partial class DataTransferRequest : RequestBase<DataTransferRequest>
    {
        //[Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }

        //[Newtonsoft.Json.JsonProperty("messageId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        //[Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Data { get; set; }
    }
}