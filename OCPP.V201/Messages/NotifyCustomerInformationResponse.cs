using OCPP.Core;

namespace OCPP.V201
{
    public partial class NotifyCustomerInformationResponse : ResponseBase<NotifyCustomerInformationRequest,NotifyCustomerInformationResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        public NotifyCustomerInformationResponse(NotifyCustomerInformationRequest request,Result result)  : base(request, result)
        {

        }
    }
}