using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Ocelot.Middleware.Responder
{
    public interface IHttpResponder
    {
        Task SetResponseOnHttpContext(HttpContext context, HttpResponseMessage response);
        void SetErrorResponseOnContext(HttpContext context, int statusCode);
    }
}
