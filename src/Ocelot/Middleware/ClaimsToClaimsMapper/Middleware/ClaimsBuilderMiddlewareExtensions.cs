using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.ClaimsToClaimsMapper.Middleware
{
    public static class ClaimsBuilderMiddlewareExtensions
    {
        public static IApplicationBuilder UseClaimsBuilderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ClaimsBuilderMiddleware>();
        }
    }
}