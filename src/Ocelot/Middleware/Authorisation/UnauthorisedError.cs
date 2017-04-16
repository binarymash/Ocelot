using Ocelot.Errors;

namespace Ocelot.Middleware.Authorisation
{
    public class UnauthorisedError : Error
    {
        public UnauthorisedError(string message) 
            : base(message, OcelotErrorCode.UnauthorizedError)
        {
        }
    }
}
