using Ocelot.Responses;

namespace Ocelot.Middleware.Requester.QoS
{
    public interface IQoSProviderHouse
    {
        Response<IQoSProvider> Get(string key);
        Response Add(string key, IQoSProvider loadBalancer);
    }
}
