using System;
using Ocelot.Errors;

namespace Ocelot.Middleware.Requester
{
    public class RequestTimedOutError : Error
    {
        public RequestTimedOutError(Exception exception) 
            : base($"Timeout making http request, exception: {exception.Message}", OcelotErrorCode.RequestTimedOutError)
        {
        }
    }
}
