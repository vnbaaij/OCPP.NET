using System;

namespace OCPP.V201
{
    /// <summary>
    /// Contains message details, for a message to be displayed on a Charging Station.
    /// </summary>

    public partial class MessageContent
    {
        //[Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageFormat Format { get; set; }

        /// <summary>
        /// Message language identifier. Contains a language code as defined in [RFC5646].
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// Message contents.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Always)]
        public string Content { get; set; }

        /// <summary>
        /// An optional custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        /// <summary>
        /// Create a new message to be displayed at a charging station.
        /// </summary>
        /// <param name="content">The message content.</param>
        /// <param name="language">The message language identifier, as defined in rfc5646.</param>
        /// <param name="format">The message format.</param>
        /// <param name="customData">An optional custom data object to allow to store any kind of customer specific data.</param>
        public MessageContent(string content, string language, MessageFormat format, CustomData customData = null)
        {
            Content = content?.Trim();
            Language = language;
            Format = format;
            CustomData = customData;

            if (string.IsNullOrEmpty(Content))
                throw new ArgumentNullException(nameof(Content), "The given message content must not be null or empty!");
        }
    }
}