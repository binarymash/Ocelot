using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamUrlCreator
{
    public class DownstreamSchemeNullOrEmptyError : Error
    {
        public DownstreamSchemeNullOrEmptyError()
            : base("downstream scheme was null or empty", OcelotErrorCode.DownstreamSchemeNullOrEmptyError)
        {
        }
    }
}