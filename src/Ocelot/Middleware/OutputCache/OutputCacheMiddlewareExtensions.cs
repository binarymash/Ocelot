using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.OutputCache
{
    public static class OutputCacheMiddlewareExtensions
    {
        public static IApplicationBuilder UseOutputCacheMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<OutputCacheMiddleware>();
        }
    }
}
