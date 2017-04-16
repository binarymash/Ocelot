using System.Security.Claims;
using Ocelot.Responses;

namespace Ocelot.Middleware.Authorisation
{
    using System.Collections.Generic;

    public interface IAuthoriser
    {
        Response<bool> Authorise(ClaimsPrincipal claimsPrincipal,
            Dictionary<string, string> routeClaimsRequirement);
    }
}
