using OCPP.V16.Core;

namespace OCPP.V16.ListManagement
{
    public record AuthorizationData (string IdTag, IdTagInfo IdTagInfo = null);
    
}