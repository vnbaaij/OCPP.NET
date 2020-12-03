using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.ListManagement
{
    public record GetLocalListVersionResponse(int ListVersion) : ResponseBase<GetLocalListVersionResponse>;
    public record SendLocalListResponse(SendLocalListRequest Request, UpdateStatus Status) : ResponseBase<SendLocalListRequest, SendLocalListResponse>(Request);
}
