using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class LogStatusNotificationResponse : ResponseBase<LogStatusNotificationRequest, LogStatusNotificationResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        public LogStatusNotificationResponse(LogStatusNotificationRequest request,Result result)  : base(request, result)
        {

        }
    
    }
}