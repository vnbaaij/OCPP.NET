namespace OCPP.V16.Core
{
    public partial class MeterValue 
    {
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("sampledValue", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SampledValue> SampledValue { get; set; } = new System.Collections.ObjectModel.Collection<SampledValue>();
    }
}