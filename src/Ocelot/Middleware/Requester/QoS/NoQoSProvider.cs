namespace Ocelot.Middleware.Requester.QoS
{
    public class NoQoSProvider : IQoSProvider
    {
        public CircuitBreaker CircuitBreaker { get; }
    }
}
