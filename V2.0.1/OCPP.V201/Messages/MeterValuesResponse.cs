using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class MeterValuesResponse : ResponseBase<MeterValuesRequest, MeterValuesResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        public MeterValuesResponse(MeterValuesRequest request ,Result result) : base(request, result)
        {

        }
    }
}