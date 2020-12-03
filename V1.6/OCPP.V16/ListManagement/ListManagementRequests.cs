using System.Collections.Generic;

namespace OCPP.V16.ListManagement
{
    public record GetLocalListVersionRequest() : RequestBase<GetLocalListVersionRequest>;
    public record SendLocalListRequest(int ListVersion, UpdateType UpdateType, ICollection<LocalAuthorizationList> LocalAuthorizationList = null) : RequestBase<SendLocalListRequest>;
    
}
