using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.ServiceDiscovery
{
    public class UnableToFindServiceDiscoveryProviderError : Error
    {
        public UnableToFindServiceDiscoveryProviderError(string message) 
            : base(message, OcelotErrorCode.UnableToFindServiceDiscoveryProviderError)
        {
        }
    }
}