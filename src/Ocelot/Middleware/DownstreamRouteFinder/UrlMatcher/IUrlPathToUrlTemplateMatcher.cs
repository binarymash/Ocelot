using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamRouteFinder.UrlMatcher
{
    public interface IUrlPathToUrlTemplateMatcher
     {
        Response<UrlMatch> Match(string upstreamUrlPath, string upstreamUrlPathTemplate);
     }
} 