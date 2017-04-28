using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.ClaimsToQueriesMapper.Middleware
{
    public static class QueryStringBuilderMiddlewareExtensions
    {
        public static IApplicationBuilder UseQueryStringBuilderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<QueryStringBuilderMiddleware>();
        }
    }
}