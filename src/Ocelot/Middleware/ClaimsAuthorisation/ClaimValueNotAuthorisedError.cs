using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.ClaimsAuthorisation
{
    public class ClaimValueNotAuthorisedError : Error
    {
        public ClaimValueNotAuthorisedError(string message) 
            : base(message, OcelotErrorCode.ClaimValueNotAuthorisedError)
        {
        }
    }
}
