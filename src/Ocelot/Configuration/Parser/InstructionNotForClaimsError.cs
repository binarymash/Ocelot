using Ocelot.Middleware.GlobalExceptionHandler;
using Ocelot.Responses;

namespace Ocelot.Configuration.Parser
{
    public class InstructionNotForClaimsError : Error
    {
        public InstructionNotForClaimsError() 
            : base("instructions did not contain claims, at the moment we only support claims extraction", OcelotErrorCode.InstructionNotForClaimsError)
        {
        }
    }
}
