using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Ocelot.Infrastructure.RequestData;
using Ocelot.Logging;

namespace Ocelot.Middleware.RequestId
{
    public class RequestIdMiddleware : OcelotMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IOcelotLogger _logger;
        private readonly IRequestScopedDataRepository _requestScopedDataRepository;

        public RequestIdMiddleware(RequestDelegate next,
            IOcelotLoggerFactory loggerFactory,
            IRequestScopedDataRepository requestScopedDataRepository)
            :base(requestScopedDataRepository)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<RequestIdMiddleware>();
            _requestScopedDataRepository = requestScopedDataRepository;
        }

        public async Task Invoke(HttpContext context)
        {         
            _logger.TraceMiddlewareEntry();

            SetOcelotRequestId(context);

            _logger.LogDebug("set requestId");

            _logger.TraceInvokeNext();
                await _next.Invoke(context);
            _logger.TraceInvokeNextCompleted();
            _logger.TraceMiddlewareCompleted();
        }

        private void SetOcelotRequestId(HttpContext context)
        {
            var key = DefaultRequestIdKey.Value;

            if (DownstreamRoute.ReRoute.RequestIdKey != null)
            {
                key = DownstreamRoute.ReRoute.RequestIdKey;
            }

            StringValues requestId;

            if (context.Request.Headers.TryGetValue(key, out requestId))
            {
                _requestScopedDataRepository.Add("RequestId", requestId.First());

                context.TraceIdentifier = requestId;
            }
        }
    }
}