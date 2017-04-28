using System;
using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Configuration.Parser
{
    public class ParsingConfigurationHeaderError : Error
    {
        public ParsingConfigurationHeaderError(Exception exception) 
            : base($"error parsing configuration eception is {exception.Message}", OcelotErrorCode.ParsingConfigurationHeaderError)
        {
        }
    }
}
