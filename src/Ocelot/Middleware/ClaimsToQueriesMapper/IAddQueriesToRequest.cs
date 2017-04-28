using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using Ocelot.Configuration;
using Ocelot.Responses;

namespace Ocelot.Middleware.ClaimsToQueriesMapper
{
    public interface IAddQueriesToRequest
    {
        Response SetQueriesOnDownstreamRequest(List<ClaimToThing> claimsToThings, IEnumerable<Claim> claims, HttpRequestMessage downstreamRequest);
    }
}
