using OCPP.Core;

namespace OCPP.V201
{
    public partial class NotifyMonitoringReportRequest : RequestBase<NotifyMonitoringReportRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        //[Newtonsoft.Json.JsonProperty("monitor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MonitoringData> Monitor { get; set; }

        /// <summary>The id of the GetMonitoringRequest that requested this report.
        ///
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }

        /// <summary>“to be continued” indicator. Indicates whether another part of the monitoringData follows in an upcoming notifyMonitoringReportRequest message. Default value when omitted is false.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("tbc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tbc { get; set; } = false;

        /// <summary>Sequence number of this message. First message starts at 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }

        /// <summary>Timestamp of the moment this message was generated at the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("generatedAt", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset GeneratedAt { get; set; }


    }
}