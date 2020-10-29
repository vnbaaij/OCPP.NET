namespace OCPP
{
    public partial class ChangeAvailabilityRequest
    {


        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSE Evse { get; set; }

        //[Newtonsoft.Json.JsonProperty("operationalStatus", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OperationalStatus OperationalStatus { get; set; }


    }
}