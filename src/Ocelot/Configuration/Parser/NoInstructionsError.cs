using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Configuration.Parser
{
    public class NoInstructionsError : Error
    {
        public NoInstructionsError(string splitToken) 
            : base($"There we no instructions splitting on {splitToken}", OcelotErrorCode.NoInstructionsError)
        {
        }
    }
}
