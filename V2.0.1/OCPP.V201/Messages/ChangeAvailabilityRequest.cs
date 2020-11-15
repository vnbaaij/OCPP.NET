using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class ChangeAvailabilityRequest : RequestBase<ChangeAvailabilityRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSE Evse { get; set; }

        //[Newtonsoft.Json.JsonProperty("operationalStatus", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OperationalStatus OperationalStatus { get; set; }


    }
}