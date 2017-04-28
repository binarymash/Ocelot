using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Configuration.Validator
{
    public class DownstreamPathTemplateAlreadyUsedError : Error
    {
        public DownstreamPathTemplateAlreadyUsedError(string message) : base(message, OcelotErrorCode.DownstreampathTemplateAlreadyUsedError)
        {
        }
    }
}
