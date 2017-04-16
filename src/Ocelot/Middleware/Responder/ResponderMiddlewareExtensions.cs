using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.Responder
{
    public static class ResponderMiddlewareExtensions
    {
        public static IApplicationBuilder UseResponderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponderMiddleware>();
        }
    }
}