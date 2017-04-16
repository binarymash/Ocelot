using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.RequestId
{
    public static class RequestIdMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestIdMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestIdMiddleware>();
        }
    }
}