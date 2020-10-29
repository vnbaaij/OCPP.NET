namespace OCPP
{

    public partial class SetMonitoringBaseRequest
    {
        //[Newtonsoft.Json.JsonProperty("monitoringBase", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MonitoringBase MonitoringBase { get; set; }
    }
}