using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Infrastructure.RequestData
{
    public class CannotFindDataError : Error
    {
        public CannotFindDataError(string message) : base(message, OcelotErrorCode.CannotFindDataError)
        {
        }
    }
}
