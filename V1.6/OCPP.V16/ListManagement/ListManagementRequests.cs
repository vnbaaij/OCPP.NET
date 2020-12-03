using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.ListManagement
{
    public record GetLocalListVersionRequest() : RequestBase<GetLocalListVersionRequest>;
    public record SendLocalListRequest(int ListVersion, UpdateType UpdateType, ICollection<LocalAuthorizationList> LocalAuthorizationList = null) : RequestBase<SendLocalListRequest>;
    
}
