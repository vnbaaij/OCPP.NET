using System;

namespace OCPP.V16.Core
{
    public partial class BootNotificationResponse : ResponseBase<BootNotificationRequest, BootNotificationResponse>
    {
        public BootNotificationResponseStatus Status { get; set; }

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
        public BootNotificationResponse(BootNotificationRequest request, Result result) : base(request, result)
        {
        }

        /// <summary>
        /// Create a BootNotification response.
        /// </summary>
        /// <param name="request">The BootNotification request leading to this response.</param>
        /// <param name="result">The result.</param>
        public BootNotificationResponse(BootNotificationRequest request, BootNotificationResponse response) : base(request, response.Result)
        {
            Status = response.Status;
            CurrentTime = response.CurrentTime;
            Interval = response.Interval;
        }
    }
}