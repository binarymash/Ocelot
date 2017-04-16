using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.Authentication
{
    public static class AuthenticationMiddlewareMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddleware>(builder);
        }
    }
}