using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.ClaimsAuthorisation.Middleware
{
    public static class AuthorisationMiddlewareMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthorisationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorisationMiddleware>();
        }
    }
}