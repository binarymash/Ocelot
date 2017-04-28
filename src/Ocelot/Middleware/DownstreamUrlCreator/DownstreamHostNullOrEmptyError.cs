using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamUrlCreator
{
    public class DownstreamHostNullOrEmptyError : Error
    {
        public DownstreamHostNullOrEmptyError()
            : base("downstream host was null or empty", OcelotErrorCode.DownstreamHostNullOrEmptyError)
        {
        }
    }
}