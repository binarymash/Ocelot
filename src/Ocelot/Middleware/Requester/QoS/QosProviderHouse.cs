using System.Collections.Generic;
using Ocelot.Responses;

namespace Ocelot.Middleware.Requester.QoS
{
    public class QosProviderHouse : IQoSProviderHouse
    {
        private readonly Dictionary<string, IQoSProvider> _qoSProviders;

        public QosProviderHouse()
        {
            _qoSProviders = new Dictionary<string, IQoSProvider>();
        }

        public Response<IQoSProvider> Get(string key)
        {
            IQoSProvider qoSProvider;

            if (_qoSProviders.TryGetValue(key, out qoSProvider))
            {
                return new OkResponse<IQoSProvider>(_qoSProviders[key]);
            }

            return new ErrorResponse<IQoSProvider>(new List<Ocelot.Errors.Error>()
            {
                new UnableToFindQoSProviderError($"unabe to find qos provider for {key}")
            });
        }

        public Response Add(string key, IQoSProvider loadBalancer)
        {
            if (!_qoSProviders.ContainsKey(key))
            {
                _qoSProviders.Add(key, loadBalancer);
            }

            _qoSProviders.Remove(key);
            _qoSProviders.Add(key, loadBalancer);
            return new OkResponse();
        }
    }
}
