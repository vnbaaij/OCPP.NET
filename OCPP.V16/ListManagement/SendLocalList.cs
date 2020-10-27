namespace OCPP.ListManagement
{



    public partial class SendLocalListRequest 
    {
        //[Newtonsoft.Json.JsonProperty("listVersion", Required = Newtonsoft.Json.Required.Always)]
        public int ListVersion { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("localAuthorizationList", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LocalAuthorizationList> LocalAuthorizationList { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("updateType", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SendLocalListRequestUpdateType UpdateType { get; set; }
    
    
    }
}