using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.ClaimsAuthorisation
{
    public class UserDoesNotHaveClaimError : Error
    {
        public UserDoesNotHaveClaimError(string message) 
            : base(message, OcelotErrorCode.UserDoesNotHaveClaimError)
        {
        }
    }
}
