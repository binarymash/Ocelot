using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Infrastructure.Claims.Parser
{
    public class CannotFindClaimError : Error
    {
        public CannotFindClaimError(string message) 
            : base(message, OcelotErrorCode.CannotFindClaimError)
        {
        }
    }
}
