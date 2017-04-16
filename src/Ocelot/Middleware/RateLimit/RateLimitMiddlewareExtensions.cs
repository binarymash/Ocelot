using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.RateLimit
{
    public static class RateLimitMiddlewareExtensions
    {
        public static IApplicationBuilder UseRateLimiting(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ClientRateLimitMiddleware>();
        }
    }
}
