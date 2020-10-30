namespace OCPP.V201
{
    public partial class DataTransferRequest
    {


        /// <summary>May be used to indicate a specific message or implementation.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("messageId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        /// <summary>Data without specified length or format. This needs to be decided by both parties (Open to implementation).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Data { get; set; }

        /// <summary>This identifies the Vendor specific implementation
        ///
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }


    }
}