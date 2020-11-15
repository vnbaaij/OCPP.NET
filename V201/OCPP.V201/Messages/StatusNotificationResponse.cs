using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class StatusNotificationResponse : ResponseBase<StatusNotificationRequest,StatusNotificationResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        public StatusNotificationResponse(StatusNotificationRequest request,Result result)  : base(request, result)
        {

        }

    }
}