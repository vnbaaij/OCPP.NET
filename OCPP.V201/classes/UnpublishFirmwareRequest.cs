namespace OCPP.V201
{public partial class UnpublishFirmwareRequest
    {
        /// <summary>The MD5 checksum over the entire firmware file as a hexadecimal string of length 32. 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("checksum", Required = Newtonsoft.Json.Required.Always)]
        public string Checksum { get; set; }
    }
}