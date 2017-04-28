using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Infrastructure.RequestData
{
    public class CannotAddDataError : Error
    {
        public CannotAddDataError(string message) : base(message, OcelotErrorCode.CannotAddDataError)
        {
        }
    }
}
