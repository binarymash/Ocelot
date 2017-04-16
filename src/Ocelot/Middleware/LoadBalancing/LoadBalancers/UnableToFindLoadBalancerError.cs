using Ocelot.Errors;

namespace Ocelot.Middleware.LoadBalancing.LoadBalancers
{
    public class UnableToFindLoadBalancerError : Errors.Error
    {
        public UnableToFindLoadBalancerError(string message) 
            : base(message, OcelotErrorCode.UnableToFindLoadBalancerError)
        {
        }
    }
}