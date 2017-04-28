using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.Authentication.Handler.Factory
{
    public class UnableToCreateAuthenticationHandlerError : Error
    {
        public UnableToCreateAuthenticationHandlerError(string message) 
            : base(message, OcelotErrorCode.UnableToCreateAuthenticationHandlerError)
        {
        }
    }
}
