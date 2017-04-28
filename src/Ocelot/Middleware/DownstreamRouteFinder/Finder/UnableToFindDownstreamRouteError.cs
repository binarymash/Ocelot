using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamRouteFinder.Finder
{
    public class UnableToFindDownstreamRouteError : Error
    {
        public UnableToFindDownstreamRouteError() : base("UnableToFindDownstreamRouteError", OcelotErrorCode.UnableToFindDownstreamRouteError)
        {
        }
    }
}
