using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.HttpStatusCodeMapper.Middleware
{
    public static class ResponderMiddlewareExtensions
    {
        public static IApplicationBuilder UseResponderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponderMiddleware>();
        }
    }
}