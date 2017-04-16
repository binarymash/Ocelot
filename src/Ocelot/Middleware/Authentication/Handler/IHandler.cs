using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Ocelot.Middleware.Authentication.Handler
{
    public interface IHandler
    {
        Task Handle(HttpContext context);
    }
}