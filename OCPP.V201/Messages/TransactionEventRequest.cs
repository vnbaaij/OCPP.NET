using OCPP.Core;

namespace OCPP.V201
{
    public partial class TransactionEventRequest : RequestBase<TransactionEventRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("event", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransactionEvent Event { get; set; }

        //[Newtonsoft.Json.JsonProperty("meterValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MeterValue> MeterValue { get; set; }

        /// <summary>The date and time at which this transaction event occurred.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }

        //[Newtonsoft.Json.JsonProperty("triggerReason", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TriggerReason TriggerReason { get; set; }

        /// <summary>Incremental sequence number, helps with determining if all messages of a transaction have been received.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }

        /// <summary>Indication that this transaction event happened when the Charging Station was offline. Default = false, meaning: the event occurred when the Charging Station was online.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("offline", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Offline { get; set; } = false;

        /// <summary>If the Charging Station is able to report the number of phases used, then it SHALL provide it. When omitted the CSMS may be able to determine the number of phases used via device management.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("numberOfPhasesUsed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfPhasesUsed { get; set; }

        /// <summary>The maximum current of the connected cable in Ampere (A).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("cableMaxCurrent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CableMaxCurrent { get; set; }

        /// <summary>This contains the Id of the reservation that terminates as a result of this transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ReservationId { get; set; }

        //[Newtonsoft.Json.JsonProperty("transactionInfo", Required = Newtonsoft.Json.Required.Always)]
        public Transaction TransactionInfo { get; set; } = new Transaction();

        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSE Evse { get; set; }

        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdToken IdToken { get; set; }
    }
}