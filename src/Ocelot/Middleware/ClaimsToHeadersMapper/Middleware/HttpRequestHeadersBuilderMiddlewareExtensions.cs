using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.ClaimsToHeadersMapper.Middleware
{
    public static class HttpRequestHeadersBuilderMiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpRequestHeadersBuilderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpRequestHeadersBuilderMiddleware>();
        }
    }
}