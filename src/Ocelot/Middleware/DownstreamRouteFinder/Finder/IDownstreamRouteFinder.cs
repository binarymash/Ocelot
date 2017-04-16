using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamRouteFinder.Finder
{
    public interface IDownstreamRouteFinder
    {
        Response<DownstreamRoute> FindDownstreamRoute(string upstreamUrlPath, string upstreamHttpMethod);
    }
}
