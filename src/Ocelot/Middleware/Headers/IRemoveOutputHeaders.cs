using System.Net.Http.Headers;
using Ocelot.Responses;

namespace Ocelot.Middleware.Headers
{
    public interface IRemoveOutputHeaders
    {
        Response Remove(HttpResponseHeaders headers);
    }
}
