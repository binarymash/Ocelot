using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Ocelot.Configuration;
using Ocelot.Responses;

namespace Ocelot.Middleware.QueryStrings
{
    public interface IAddQueriesToRequest
    {
        Response SetQueriesOnContext(List<ClaimToThing> claimsToThings,
            HttpContext context);
    }
}
