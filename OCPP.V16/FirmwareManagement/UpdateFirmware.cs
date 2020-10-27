namespace OCPP.FirmwareManagement
{
    

    
    public partial class UpdateFirmwareRequest 
    {
        //[Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Always)]
        public System.Uri Location { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("retries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Retries { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("retrieveDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset RetrieveDate { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("retryInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RetryInterval { get; set; }
    
    
    }
}