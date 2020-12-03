using System.Text.Json.Serialization;

namespace OCPP.V16.Core
{
    public record AuthorizeRequest(string IdTag) : RequestBase<AuthorizeRequest>;
}