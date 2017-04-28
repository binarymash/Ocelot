using System.Net.Http;
using System.Threading.Tasks;

namespace Ocelot.Middleware.DownstreamRequestSender
{
    public interface IHttpClient
    {
        HttpClient Client { get; }

        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    }
}
