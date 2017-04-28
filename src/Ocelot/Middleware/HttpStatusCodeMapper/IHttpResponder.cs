using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Ocelot.Middleware.HttpStatusCodeMapper
{
    public interface IHttpResponder
    {
        Task SetResponseOnHttpContext(HttpContext context, HttpResponseMessage response);
        void SetErrorResponseOnContext(HttpContext context, int statusCode);
    }
}
