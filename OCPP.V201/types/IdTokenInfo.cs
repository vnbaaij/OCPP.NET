using System;
using System.Collections.Generic;

namespace OCPP.V201
{

    /// <summary>
    /// Contains status information about an identifier.
    /// It is advised to not stop charging for a token that expires during charging, as ExpiryDate is only used for caching purposes. If ExpiryDate is not given, the status has no end date.
    /// </summary>
    public partial class IdTokenInfo
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AuthorizationStatus Status { get; set; } = AuthorizationStatus.Unknown;

        /// <summary>
        /// Optional Date and Time after which the token must be considered invalid.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("cacheExpiryDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? CacheExpiryDateTime { get; set; }

        /// <summary>
        /// Priority from a business point of view. Default priority is 0, The range is from -9 to 9. Higher values indicate a higher priority. The chargingPriority in TransactionEventResponse overrules this one.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("chargingPriority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ChargingPriority { get; set; } = 0;

        /// <summary>
        /// Only used when the IdToken is only valid for one or more specific EVSEs, not for the entire Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ICollection<int> EvseIds { get; set; }

        /// <summary>
        /// Additional identification token.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("groupIdToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdToken GroupIdToken { get; set; }

        /// <summary>
        /// Preferred user interface language of identifier user. Contains a language code as defined in <ref-RFC5646>RFC5646</ref-RFC5646>.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("language1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language1 { get; set; }

        /// <summary>
        /// Second preferred user interface language of identifier user. Don’t use when language1 is omitted, has to be different from language1. Contains a language code as defined in <ref-RFC5646>RFC5646</ref-RFC5646>.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("language2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language2 { get; set; }

        /// <summary>
        /// An optional message to be displayed at a charging station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("personalMessage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MessageContent PersonalMessage { get; set; }

        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        /// <summary>
        /// Create a new status information about an identifier.
        /// </summary>
        /// <param name="status">The authorization status.</param>
        /// <param name="chargingPriority">The optional charging priority from a business point of view, ranging from -9 to 9 with a default value of 0. Higher values indicate a higher priority.</param>
        /// <param name="cacheExpiryDateTime">The optional timestamp after which the token must be considered invalid.</param>
        /// <param name="evseIds">The identification token is only valid fot the given optional enumeration of EVSE identifications.</param>
        /// <param name="groupIdToken">Additional identification token.</param>
        /// <param name="language1">The first optional preferred user interface language of identifier user.</param>
        /// <param name="language2">The second optional preferred user interface language of identifier user.</param>
        /// <param name="personalMessage">An optional message to be displayed at a charging station.</param>
        /// <param name="customData">An optional custom data object to allow to store any kind of customer specific data.</param>
        public IdTokenInfo(AuthorizationStatus status = AuthorizationStatus.Unknown, int chargingPriority = 0, DateTime? cacheExpiryDateTime = null, ICollection<int> evseIds = null, IdToken groupIdToken = null, string language1 = null, string language2 = null, MessageContent personalMessage = null, CustomData customData = null)
        {
            Status = status;
            ChargingPriority = chargingPriority;
            CacheExpiryDateTime = cacheExpiryDateTime;
            EvseIds = evseIds ?? new int[0];
            GroupIdToken = groupIdToken;
            Language1 = language1;
            Language2 = language2;
            PersonalMessage = personalMessage;
            CustomData = customData;

        }
    }
}