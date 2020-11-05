using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class NotifyMonitoringReportResponse : ResponseBase<NotifyMonitoringReportRequest,NotifyMonitoringReportResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        public NotifyMonitoringReportResponse(NotifyMonitoringReportRequest request,Result result)  : base(request, result)
        {

        }

    }
}