using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class ReportChargingProfilesResponse : ResponseBase<ReportChargingProfilesRequest, ReportChargingProfilesResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        public ReportChargingProfilesResponse(ReportChargingProfilesRequest request,Result result)  : base(request, result)
        {

        }
    }
}