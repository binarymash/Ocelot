using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Ocelot.Configuration;
using Ocelot.Responses;

namespace Ocelot.Middleware.ClaimsToClaimsMapper
{
    public interface IAddClaimsToRequest
    {
        Response SetClaimsOnContext(List<ClaimToThing> claimsToThings,
            HttpContext context);
    }
}
