using Microsoft.AspNetCore.Builder;

namespace Ocelot.Middleware.LoadBalancer.Middleware
{
 public static class LoadBalancingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoadBalancingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoadBalancingMiddleware>();
        }
    }
}