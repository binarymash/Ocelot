using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.LoadBalancer.LoadBalancers
{
    public class UnableToFindLoadBalancerError : Error
    {
        public UnableToFindLoadBalancerError(string message) 
            : base(message, OcelotErrorCode.UnableToFindLoadBalancerError)
        {
        }
    }
}