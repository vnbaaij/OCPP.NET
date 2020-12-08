using System;

namespace OCPP.V16
{
    public interface IAction
    {
        /// <summary>
        ///  The unique Id of each message send/received
        /// </summary>
        Guid MessageId { get; set; }
    }
}
