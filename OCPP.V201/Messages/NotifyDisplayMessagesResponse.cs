using OCPP.Core;

namespace OCPP.V201
{
    public partial class NotifyDisplayMessagesResponse : ResponseBase<NotifyDisplayMessagesRequest, NotifyDisplayMessagesResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        public NotifyDisplayMessagesResponse(NotifyDisplayMessagesRequest request,Result result)  : base(request, result)
        {

        }
    }
}