using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware
{
    public class UnauthenticatedError : Error
    {
        public UnauthenticatedError(string message) : base(message, OcelotErrorCode.UnauthenticatedError)
        {
        }
    }
}
