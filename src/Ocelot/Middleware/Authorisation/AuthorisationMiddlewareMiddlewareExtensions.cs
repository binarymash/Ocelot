namespace Ocelot.Middleware.Authorisation
{
    using Microsoft.AspNetCore.Builder;

    public static class AuthorisationMiddlewareMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthorisationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorisationMiddleware>();
        }
    }
}