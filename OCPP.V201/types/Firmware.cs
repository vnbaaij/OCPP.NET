namespace OCPP
{
    /// <summary>Firmware
    /// urn:x-enexis:ecdm:uid:2:233291
    /// Represents a copy of the firmware that can be loaded/updated on the Charging Station.
    /// </summary>

    public partial class Firmware 
    {
        /// <summary>Firmware. Location. URI
        /// urn:x-enexis:ecdm:uid:1:569460
        /// URI defining the origin of the firmware.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Always)]
        public string Location { get; set; }
    
        /// <summary>Firmware. Retrieve. Date_ Time
        /// urn:x-enexis:ecdm:uid:1:569461
        /// Date and time at which the firmware shall be retrieved.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retrieveDateTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset RetrieveDateTime { get; set; }
    
        /// <summary>Firmware. Install. Date_ Time
        /// urn:x-enexis:ecdm:uid:1:569462
        /// Date and time at which the firmware shall be installed.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("installDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset InstallDateTime { get; set; }
    
        /// <summary>Certificate with which the firmware was signed.
        /// PEM encoded X.509 certificate.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("signingCertificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SigningCertificate { get; set; }
    
        /// <summary>Firmware. Signature. Signature
        /// urn:x-enexis:ecdm:uid:1:569464
        /// Base64 encoded firmware signature.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("signature", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Signature { get; set; }
    }
}