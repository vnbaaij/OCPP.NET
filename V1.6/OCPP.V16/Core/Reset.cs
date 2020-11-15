
namespace OCPP.V16.Core
{
    public partial class ResetRequest : RequestBase<ResetRequest>
    {
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResetRequestType Type { get; set; }
    }
}