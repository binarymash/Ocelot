using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.DownstreamUrlCreator.Middleware
{
    public static class DownstreamUrlCreatorMiddlewareExtensions
    {
        public static IApplicationBuilder UseDownstreamUrlCreatorMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DownstreamUrlCreatorMiddleware>();
        }
    }
}