namespace OCPP
{
    public partial class ReserveNowRequest
    {
        /// <summary>Id of reservation.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }

        /// <summary>Date and time at which the reservation expires.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("expiryDateTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset ExpiryDateTime { get; set; }

        //[Newtonsoft.Json.JsonProperty("connector", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Connector Connector { get; set; }

        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdToken IdToken { get; set; } = new IdToken();

        /// <summary>This contains ID of the evse to be reserved.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }

        //[Newtonsoft.Json.JsonProperty("groupIdToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdToken GroupIdToken { get; set; }
    }
}