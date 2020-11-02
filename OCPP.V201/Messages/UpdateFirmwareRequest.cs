using OCPP.Core;

namespace OCPP.V201
{
    public partial class UpdateFirmwareRequest : RequestBase<UpdateFirmwareRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>This specifies how many times Charging Station must try to download the firmware before giving up. If this field is not present, it is left to Charging Station to decide how many times it wants to retry.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Retries { get; set; }
    
        /// <summary>The interval in seconds after which a retry may be attempted. If this field is not present, it is left to Charging Station to decide how long to wait between attempts.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retryInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RetryInterval { get; set; }
    
        /// <summary>The Id of this request
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("firmware", Required = Newtonsoft.Json.Required.Always)]
        public Firmware Firmware { get; set; } = new Firmware();
    }
}