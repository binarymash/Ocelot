using System.Net.Http;
using System.Threading.Tasks;
using Ocelot.Responses;

namespace Ocelot.Middleware.Requester
{
    public interface IHttpRequester
    {
        Task<Response<HttpResponseMessage>> GetResponse(Request.Request request);
    }
}
