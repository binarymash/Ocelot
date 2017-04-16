using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Ocelot.Infrastructure.RequestData;
using Ocelot.Logging;

namespace Ocelot.Middleware.Requester
{
    public class HttpRequesterMiddleware : OcelotMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IHttpRequester _requester;
        private readonly IOcelotLogger _logger;

        public HttpRequesterMiddleware(RequestDelegate next,
            IOcelotLoggerFactory loggerFactory,
            IHttpRequester requester, 
            IRequestScopedDataRepository requestScopedDataRepository)
            :base(requestScopedDataRepository)
        {
            _next = next;
            _requester = requester;
            _logger = loggerFactory.CreateLogger<HttpRequesterMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogDebug("started calling requester middleware");

            var response = await _requester.GetResponse(Request);

            if (response.IsError)
            {
                _logger.LogDebug("IHttpRequester returned an error, setting pipeline error");

                SetPipelineError(response.Errors);
                return;
            }

            _logger.LogDebug("setting http response message");

            SetHttpResponseMessageThisRequest(response.Data);

            _logger.LogDebug("returning to calling middleware");
        }
    }
}