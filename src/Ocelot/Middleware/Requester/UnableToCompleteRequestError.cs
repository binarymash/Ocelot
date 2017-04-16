using System;
using Ocelot.Errors;

namespace Ocelot.Middleware.Requester
{
    public class UnableToCompleteRequestError : Error
    {
        public UnableToCompleteRequestError(Exception exception) 
            : base($"Error making http request, exception: {exception.Message}", OcelotErrorCode.UnableToCompleteRequestError)
        {
        }
    }
}
