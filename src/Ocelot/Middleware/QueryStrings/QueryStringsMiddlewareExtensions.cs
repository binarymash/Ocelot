using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.QueryStrings
{
    public static class QueryStringsMiddlewareExtensions
    {
        public static IApplicationBuilder UseQueryStringBuilderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<QueryStringsMiddleware>();
        }
    }
}