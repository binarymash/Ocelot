using System;
using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamRequestInitialiser.Mapper
{
    public class UnmappableRequestError : Error
    {
        public UnmappableRequestError(Exception ex) : base($"Error when parsing incoming request, exception: {ex.Message}", OcelotErrorCode.UnmappableRequestError)
        {
        }
    }
}
