using System.Net.Http;
using Ocelot.Logging;
using Ocelot.Middleware.DownstreamRequestSender.QoS;

namespace Ocelot.Middleware.DownstreamRequestSender
{
    public interface IHttpClientBuilder
    {

        /// <summary>
        /// Sets a PollyCircuitBreakingDelegatingHandler .
        /// </summary>
        IHttpClientBuilder WithQos(IQoSProvider qosProvider, IOcelotLogger logger);            

        /// <summary>
        /// Creates the <see cref="HttpClient"/>
        /// </summary>
        IHttpClient Create();
    }
}
