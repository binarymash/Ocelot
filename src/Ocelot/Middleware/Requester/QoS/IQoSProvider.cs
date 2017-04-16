namespace Ocelot.Middleware.Requester.QoS
{
    public interface IQoSProvider
    {
        CircuitBreaker CircuitBreaker { get; }
    }
}
