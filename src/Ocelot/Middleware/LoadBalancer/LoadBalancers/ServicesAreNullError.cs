using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.LoadBalancer.LoadBalancers
{
    public class ServicesAreNullError : Error
    {
        public ServicesAreNullError(string message)
            : base(message, OcelotErrorCode.ServicesAreNullError)
        {
        }
    }
}