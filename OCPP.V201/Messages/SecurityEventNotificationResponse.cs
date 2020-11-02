using OCPP.Core;

namespace OCPP.V201
{
    public partial class SecurityEventNotificationResponse : ResponseBase<SecurityEventNotificationRequest, SecurityEventNotificationResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        public SecurityEventNotificationResponse(SecurityEventNotificationRequest request,Result result)  : base(request, result)
        {

        }
    }
}