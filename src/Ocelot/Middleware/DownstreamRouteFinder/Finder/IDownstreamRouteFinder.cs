using System.Threading.Tasks;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamRouteFinder.Finder
{
    public interface IDownstreamRouteFinder
    {
        Task<Response<DownstreamRoute>> FindDownstreamRoute(string upstreamUrlPath, string upstreamHttpMethod);
    }
}
