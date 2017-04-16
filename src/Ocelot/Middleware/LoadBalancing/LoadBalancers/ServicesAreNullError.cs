using Ocelot.Errors;

namespace Ocelot.Middleware.LoadBalancing.LoadBalancers
{
    public class ServicesAreNullError : Error
    {
        public ServicesAreNullError(string message)
            : base(message, OcelotErrorCode.ServicesAreNullError)
        {
        }
    }
}