using System.Threading.Tasks;
using Ocelot.Responses;
using Ocelot.Values;

namespace Ocelot.Middleware.LoadBalancer.LoadBalancers
{
    public interface ILoadBalancer
    {
        Task<Response<HostAndPort>> Lease();
        void Release(HostAndPort hostAndPort);
    }
}