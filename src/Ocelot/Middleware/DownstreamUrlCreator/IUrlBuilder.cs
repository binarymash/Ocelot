using Ocelot.Responses;
using Ocelot.Values;

namespace Ocelot.Middleware.DownstreamUrlCreator
{
    public interface IUrlBuilder
    {
        Response<DownstreamUrl> Build(string downstreamPath, string downstreamScheme, HostAndPort downstreamHostAndPort);
    }
}
