namespace OCPP.V201
{
    /// <summary>Meter_ Value
    /// urn:x-oca:ocpp:uid:2:233265
    /// Collection of one or more sampled values in MeterValuesRequest and TransactionEvent. All sampled values in a MeterValue are sampled at the same point in time.
    /// </summary>

    public partial class MeterValue
    {
        //[Newtonsoft.Json.JsonProperty("sampledValue", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SampledValue> SampledValue { get; set; } = new System.Collections.ObjectModel.Collection<SampledValue>();

        /// <summary>Meter_ Value. Timestamp. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569259
        /// Timestamp for measured value(s).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    }
}