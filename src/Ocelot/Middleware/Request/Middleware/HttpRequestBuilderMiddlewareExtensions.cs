using Microsoft.AspNetCore.Builder;
using Ocelot.Middleware.DownstreamRequestInitialiser.Middleware;

namespace Ocelot.Middleware.Request.Middleware
{
    public static class HttpRequestBuilderMiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpRequestBuilderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpRequestBuilderMiddleware>();
        }

        public static IApplicationBuilder UseDownstreamRequestInitialiser(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DownstreamRequestInitialiserMiddleware>();
        }
    }
}