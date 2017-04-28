using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Configuration.Validator
{
    public class UnsupportedAuthenticationProviderError : Error
    {
        public UnsupportedAuthenticationProviderError(string message) 
            : base(message, OcelotErrorCode.UnsupportedAuthenticationProviderError)
        {
        }
    }
}
