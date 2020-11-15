using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class UnpublishFirmwareRequest : RequestBase<UnpublishFirmwareRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>The MD5 checksum over the entire firmware file as a hexadecimal string of length 32.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("checksum", Required = Newtonsoft.Json.Required.Always)]
        public string Checksum { get; set; }
    }
}