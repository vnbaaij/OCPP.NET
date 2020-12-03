using OCPP.V16;

namespace OCPP.V16.RemoteTrigger
{
    public record TriggerMessageRequest(MessageTrigger RequestedMessage, int? ConnectorId = null) : RequestBase<TriggerMessageRequest>; 
}