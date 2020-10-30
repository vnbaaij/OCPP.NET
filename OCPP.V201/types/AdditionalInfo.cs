using System;

namespace OCPP.V201
{
    /// <summary>
    /// Contains a case insensitive identifier to use for the authorization and the  of authorization to support multiple forms of identifiers.
    /// </summary>

    public partial class AdditionalInfo
    {
        /// <summary>
        /// This field specifies the additional IdToken.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("additionalIdToken", Required = Newtonsoft.Json.Required.Always)]
        public string AdditionalIdToken { get; set; }

        /// <summary>
        /// This defines the  of the additionalIdToken. This is a custom , so the implementation needs to be agreed upon by all involved parties.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("", Required = Newtonsoft.Json.Required.Always)]
        public string Type { get; set; }

        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomData CustomData { get; set; }

        /// <summary>
        /// Create a new case insensitive authorization identifier.
        /// </summary>
        /// <param name="additionalIdToken">This field specifies the additional IdToken.</param>
        /// <param name="type">This defines the type of the additionalIdToken. This is a custom type, so the implementation needs to be agreed upon by all involved parties.</param>
        /// <param name="customData">An optional custom data object to allow to store any kind of customer specific data.</param>
        public AdditionalInfo(string additionalIdToken, string type, CustomData customData = null)
        {
            AdditionalIdToken = AdditionalIdToken?.Trim() ?? throw new ArgumentNullException(nameof(AdditionalIdToken), "The given additional identification token must not be null or empty!");
            Type = Type?.Trim() ?? throw new ArgumentNullException(nameof(Type), "The given type must not be null or empty!");
            CustomData = CustomData;
        }
    }
}