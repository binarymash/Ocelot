using System.Net.Http.Headers;
using Ocelot.Responses;

namespace Ocelot.Middleware.ClaimsToHeadersMapper
{
    public interface IRemoveOutputHeaders
    {
        Response Remove(HttpResponseHeaders headers);
    }
}
