namespace OCPP.V201
{
    public partial class SetDisplayMessageRequest
    {
        //[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        public MessageInfo Message { get; set; } = new MessageInfo();
    }
}