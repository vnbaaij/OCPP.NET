namespace OCPP
{
    public partial class SendLocalListRequest
    {


        //[Newtonsoft.Json.JsonProperty("localAuthorizationList", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AuthorizationData> LocalAuthorizationList { get; set; }

        /// <summary>In case of a full update this is the version number of the full list. In case of a differential update it is the version number of the list after the update has been applied.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("versionNumber", Required = Newtonsoft.Json.Required.Always)]
        public int VersionNumber { get; set; }

        //[Newtonsoft.Json.JsonProperty("update", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Update Update { get; set; }


    }
}