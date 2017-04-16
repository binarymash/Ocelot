using System.Net.Http;
using System.Threading.Tasks;
using Ocelot.Middleware.Request;
using Ocelot.Responses;

namespace Ocelot.Requester
{
    public interface IHttpRequester
    {
        Task<Response<HttpResponseMessage>> GetResponse(Request request);
    }
}
