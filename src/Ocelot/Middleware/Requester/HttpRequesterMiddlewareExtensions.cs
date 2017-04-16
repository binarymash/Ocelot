using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.Requester
{
    public static class HttpRequesterMiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpRequesterMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpRequesterMiddleware>();
        }
    }
}