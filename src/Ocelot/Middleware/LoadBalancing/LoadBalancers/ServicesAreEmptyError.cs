using Ocelot.Errors;

namespace Ocelot.Middleware.LoadBalancing.LoadBalancers
{
    public class ServicesAreEmptyError : Error
    {
        public ServicesAreEmptyError(string message)
            : base(message, OcelotErrorCode.ServicesAreEmptyError)
        {
        }
    }
}