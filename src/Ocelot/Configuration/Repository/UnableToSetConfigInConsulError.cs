using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Configuration.Repository
{
    public class UnableToSetConfigInConsulError : Error
    {
        public UnableToSetConfigInConsulError(string message) 
            : base(message, OcelotErrorCode.UnableToSetConfigInConsulError)
        {
        }
    }
}