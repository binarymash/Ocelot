using System.Threading.Tasks;
using Ocelot.Configuration;

namespace Ocelot.Middleware.LoadBalancer.LoadBalancers
{
    public interface ILoadBalancerFactory
    {
        Task<ILoadBalancer> Get(ReRoute reRoute);
    }
}