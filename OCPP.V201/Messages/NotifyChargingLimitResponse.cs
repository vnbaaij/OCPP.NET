using OCPP.Core;

namespace OCPP.V201
{
    public partial class NotifyChargingLimitResponse : ResponseBase<NotifyChargingLimitRequest, NotifyChargingLimitResponse> 
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        public NotifyChargingLimitResponse(NotifyChargingLimitRequest request, Result result) : base(request, result)
        {

        }

    }
}