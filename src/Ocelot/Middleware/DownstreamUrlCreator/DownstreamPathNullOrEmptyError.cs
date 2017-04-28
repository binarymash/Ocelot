using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamUrlCreator
{
    public class DownstreamPathNullOrEmptyError : Error
    {
        public DownstreamPathNullOrEmptyError() 
            : base("downstream path was null or empty", OcelotErrorCode.DownstreamPathNullOrEmptyError)
        {
        }
    }
}