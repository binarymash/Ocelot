using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamRequestSender.QoS
{
    public class UnableToFindQoSProviderError : Error
    {
        public UnableToFindQoSProviderError(string message) 
            : base(message, OcelotErrorCode.UnableToFindQoSProviderError)
        {
        }
    }
}
