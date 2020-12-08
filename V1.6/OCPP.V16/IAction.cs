using System;

namespace OCPP.V16
{
    public interface IAction
    {
        /// <summary>
        ///  The unique Id of each message send/received
        /// </summary>
        Guid MessageId { get; set; }

        /// <summary>
        ///  The name of the action (without the Request/Response suffix)
        /// </summary>
        string Name { get; set; }
    }
}
