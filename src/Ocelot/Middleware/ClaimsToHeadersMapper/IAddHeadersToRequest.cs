using System.Collections.Generic;
using System.Net.Http;
using Ocelot.Configuration;
using Ocelot.Responses;

namespace Ocelot.Middleware.ClaimsToHeadersMapper
{
    public interface IAddHeadersToRequest
    {
        Response SetHeadersOnDownstreamRequest(List<ClaimToThing> claimsToThings, IEnumerable<System.Security.Claims.Claim> claims, HttpRequestMessage downstreamRequest);
    }
}
