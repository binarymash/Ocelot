using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.RequestIdTracker.Middleware
{
    public static class RequestIdMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestIdMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestIdMiddleware>();
        }
    }
}