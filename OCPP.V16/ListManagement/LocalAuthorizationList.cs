using OCPP.Core;

namespace OCPP.ListManagement
{
    public partial class LocalAuthorizationList 
    {
        //[Newtonsoft.Json.JsonProperty("idTag", Required = Newtonsoft.Json.Required.Always)]
        public string IdTag { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idTagInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTagInfo IdTagInfo { get; set; }
    
    
    }
}