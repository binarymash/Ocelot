using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Configuration.Validator
{
    public class DownstreamPathTemplateContainsSchemeError : Error
    {
        public DownstreamPathTemplateContainsSchemeError(string message) 
            : base(message, OcelotErrorCode.DownstreamPathTemplateContainsSchemeError)
        {
        }
    }
}
