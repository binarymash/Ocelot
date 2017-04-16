using Ocelot.Errors;

namespace Ocelot.Middleware.LoadBalancing.LoadBalancers
{
    public class UnableToFindLoadBalancerError : Error
    {
        public UnableToFindLoadBalancerError(string message) 
            : base(message, OcelotErrorCode.UnableToFindLoadBalancerError)
        {
        }
    }
}