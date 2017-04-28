using System.Collections.Generic;
using System.Security.Claims;
using Ocelot.Responses;

namespace Ocelot.Middleware.ClaimsAuthorisation
{
    public interface IAuthoriser
    {
        Response<bool> Authorise(ClaimsPrincipal claimsPrincipal,
            Dictionary<string, string> routeClaimsRequirement);
    }
}
