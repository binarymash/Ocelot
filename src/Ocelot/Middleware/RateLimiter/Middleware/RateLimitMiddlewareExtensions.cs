using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.RateLimiter.Middleware
{
    public static class RateLimitMiddlewareExtensions
    {
        public static IApplicationBuilder UseRateLimiting(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ClientRateLimitMiddleware>();
        }
    }
}
