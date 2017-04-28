using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.LoadBalancer.LoadBalancers
{
    public class ServicesAreEmptyError : Error
    {
        public ServicesAreEmptyError(string message)
            : base(message, OcelotErrorCode.ServicesAreEmptyError)
        {
        }
    }
}