using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.DownstreamRouteFinder.Middleware
{
    public static class DownstreamRouteFinderMiddlewareExtensions
    {
        public static IApplicationBuilder UseDownstreamRouteFinderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DownstreamRouteFinderMiddleware>();
        }
    }
}