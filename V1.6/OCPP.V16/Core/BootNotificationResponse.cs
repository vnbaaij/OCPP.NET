using System;
using System.Text.Json.Serialization;

namespace OCPP.V16.Core
{
    public partial class BootNotificationResponse : ResponseBase<BootNotificationRequest, BootNotificationResponse>
    {
        public RegistrationStatus Status { get; set; }

        public DateTime CurrentTime { get; set; }

        public int Interval { get; set; }

        //public BootNotificationResponse() : base()
        //{

        //}

        /// <summary>
        /// Create a BootNotification response.
        /// </summary>
        /// <param name="request">The BootNotification request leading to this response.</param>
        /// <param name="result">The result.</param>
        [JsonConstructor]
        public BootNotificationResponse(BootNotificationRequest request) : base(request)
        {
        }

        /// <summary>
        /// Create a BootNotification response.
        /// </summary>
        /// <param name="request">The BootNotification request leading to this response.</param>
        /// <param name="result">The result.</param>
        public BootNotificationResponse(BootNotificationRequest request, BootNotificationResponse response) : base(request)
        {
            Status = response.Status;
            CurrentTime = response.CurrentTime;
            Interval = response.Interval;
        }
    }
}