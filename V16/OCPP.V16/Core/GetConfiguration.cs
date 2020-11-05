using OCPP.V16;

using OCPP.V16;
namespace OCPP.V16.Core
{
    public partial class GetConfigurationRequest : RequestBase<GetConfigurationRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Key { get; set; }
    }
}