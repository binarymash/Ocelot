using Ocelot.Errors;

namespace Ocelot.Middleware.Authorisation
{
    public class ClaimValueNotAuthorisedError : Error
    {
        public ClaimValueNotAuthorisedError(string message) 
            : base(message, OcelotErrorCode.ClaimValueNotAuthorisedError)
        {
        }
    }
}
