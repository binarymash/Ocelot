using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.ClaimsBuilder
{
    public static class ClaimsBuilderMiddlewareExtensions
    {
        public static IApplicationBuilder UseClaimsBuilderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ClaimsBuilderMiddleware>();
        }
    }
}