using Ocelot.Errors;

namespace Ocelot.Middleware.Requester.QoS
{
    public class UnableToFindQoSProviderError : Error
    {
        public UnableToFindQoSProviderError(string message) 
            : base(message, OcelotErrorCode.UnableToFindQoSProviderError)
        {
        }
    }
}
