using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class CostUpdatedResponse : ResponseBase<CostUpdatedRequest, CostUpdatedResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        public CostUpdatedResponse(CostUpdatedRequest request,Result result)  : base(request, result)
        {

        }

    }
}