using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ocelot.Logging;
using Polly;
using Polly.CircuitBreaker;

namespace Ocelot.Middleware.Requester
{
    public class PollyCircuitBreakingDelegatingHandler : DelegatingHandler
    {
        private readonly QoS.IQoSProvider _qoSProvider;
        private readonly IOcelotLogger _logger;

        public PollyCircuitBreakingDelegatingHandler(
            QoS.IQoSProvider qoSProvider,
            IOcelotLogger logger)
        {
            _qoSProvider = qoSProvider;
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                return await Policy
                    .WrapAsync(_qoSProvider.CircuitBreaker.CircuitBreakerPolicy, _qoSProvider.CircuitBreaker.TimeoutPolicy)
                    .ExecuteAsync(() => base.SendAsync(request,cancellationToken));
            }
            catch (BrokenCircuitException ex)
            {
                _logger.LogError($"Reached to allowed number of exceptions. Circuit is open",ex);
                throw;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError($"Error in CircuitBreakingDelegatingHandler.SendAync", ex);
                throw;
            }
        }
    }
}
