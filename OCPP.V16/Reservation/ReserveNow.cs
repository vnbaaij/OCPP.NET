namespace OCPP.Reservation

{
    

    
    public partial class ReserveNowRequest 
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("expiryDate", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset ExpiryDate { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idTag", Required = Newtonsoft.Json.Required.Always)]
        public string IdTag { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("parentIdTag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParentIdTag { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.Always)]
        public int ReservationId { get; set; }
    
    
    }
}