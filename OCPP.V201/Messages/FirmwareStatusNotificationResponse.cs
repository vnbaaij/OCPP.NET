using OCPP.Core;

namespace OCPP.V201
{
    public partial class FirmwareStatusNotificationResponse : ResponseBase<FirmwareStatusNotificationRequest,FirmwareStatusNotificationResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        public FirmwareStatusNotificationResponse(FirmwareStatusNotificationRequest request,Result result)  : base(request, result)
        {

        }



    }
}