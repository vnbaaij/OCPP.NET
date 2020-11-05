namespace OCPP.V16.SmartCharging
{



    public partial class ClearChargingProfileResponse 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ClearChargingProfileResponseStatus Status { get; set; }
    }
}