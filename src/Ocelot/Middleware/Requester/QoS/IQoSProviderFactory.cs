using Ocelot.Configuration;

namespace Ocelot.Middleware.Requester.QoS
{
    public interface IQoSProviderFactory
    {
        IQoSProvider Get(ReRoute reRoute);
    }
}
