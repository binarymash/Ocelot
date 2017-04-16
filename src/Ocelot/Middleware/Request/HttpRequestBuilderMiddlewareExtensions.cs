using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.Request
{
    public static class HttpRequestBuilderMiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpRequestBuilderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpRequestBuilderMiddleware>();
        }
    }
}