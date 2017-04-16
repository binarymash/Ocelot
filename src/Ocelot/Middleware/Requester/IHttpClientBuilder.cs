using Ocelot.Logging;

namespace Ocelot.Middleware.Requester
{
    public interface IHttpClientBuilder
    {

        /// <summary>
        /// Sets a PollyCircuitBreakingDelegatingHandler .
        /// </summary>
        IHttpClientBuilder WithQos(QoS.IQoSProvider qosProvider, IOcelotLogger logger);            

        /// <summary>
        /// Creates the <see cref="HttpClient"/>
        /// </summary>
        IHttpClient Create();
    }
}
