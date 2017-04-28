using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.ClaimsAuthorisation
{
    public class UnauthorisedError : Error
    {
        public UnauthorisedError(string message) 
            : base(message, OcelotErrorCode.UnauthorizedError)
        {
        }
    }
}
