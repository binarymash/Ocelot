using System;
using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Middleware.DownstreamRequestSender
{
    public class UnableToCompleteRequestError : Error
    {
        public UnableToCompleteRequestError(Exception exception) 
            : base($"Error making http request, exception: {exception.Message}", OcelotErrorCode.UnableToCompleteRequestError)
        {
        }
    }
}
