namespace OCPP
{
    /// <summary>Represent a signed version of the meter value.
    /// </summary>

    public partial class SignedMeterValue
    {
        /// <summary>Base64 encoded, contains the signed data which might contain more then just the meter value. It can contain information like timestamps, reference to a customer etc.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("signedMeterData", Required = Newtonsoft.Json.Required.Always)]
        public string SignedMeterData { get; set; }

        /// <summary>Method used to create the digital signature.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("signingMethod", Required = Newtonsoft.Json.Required.Always)]
        public string SigningMethod { get; set; }

        /// <summary>Method used to encode the meter values before applying the digital signature algorithm.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("encodingMethod", Required = Newtonsoft.Json.Required.Always)]
        public string EncodingMethod { get; set; }

        /// <summary>Base64 encoded, sending depends on configuration variable _PublicKeyWithSignedMeterValue_.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("publicKey", Required = Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; }
    }
}