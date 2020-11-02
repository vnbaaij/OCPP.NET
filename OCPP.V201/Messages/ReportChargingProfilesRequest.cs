using OCPP.Core;

namespace OCPP.V201
{
    public partial class ReportChargingProfilesRequest : RequestBase<ReportChargingProfilesRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Id used to match the &amp;lt;&amp;lt;getchargingprofilesrequest, GetChargingProfilesRequest&amp;gt;&amp;gt; message with the resulting ReportChargingProfilesRequest messages. When the CSMS provided a requestId in the &amp;lt;&amp;lt;getchargingprofilesrequest, GetChargingProfilesRequest&amp;gt;&amp;gt;, this field SHALL contain the same value.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingLimitSource", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingLimitSource ChargingLimitSource { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfile", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ChargingProfile> ChargingProfile { get; set; } = new System.Collections.ObjectModel.Collection<ChargingProfile>();
    
        /// <summary>To Be Continued. Default value when omitted: false. false indicates that there are no further messages as part of this report.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("tbc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tbc { get; set; } = false;
    
        /// <summary>The evse to which the charging profile applies. If evseId = 0, the message contains an overall limit for the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    }
}