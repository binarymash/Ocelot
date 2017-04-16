using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Ocelot.Responses;

namespace Ocelot.Middleware.Authentication.Handler.Creator
{
    using AuthenticationOptions = Configuration.AuthenticationOptions;

    public interface IAuthenticationHandlerCreator
    {
        Response<RequestDelegate> Create(IApplicationBuilder app, AuthenticationOptions authOptions);
    }
}
