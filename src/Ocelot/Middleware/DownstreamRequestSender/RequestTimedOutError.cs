using System;
using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamRequestSender
{
    public class RequestTimedOutError : Error
    {
        public RequestTimedOutError(Exception exception) 
            : base($"Timeout making http request, exception: {exception.Message}", OcelotErrorCode.RequestTimedOutError)
        {
        }
    }
}
