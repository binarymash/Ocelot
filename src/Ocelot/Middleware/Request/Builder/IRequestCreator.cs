using System.Net.Http;
using System.Threading.Tasks;
using Ocelot.Middleware.DownstreamRequestSender.QoS;
using Ocelot.Responses;

namespace Ocelot.Middleware.Request.Builder
{
    public interface IRequestCreator
    {
        Task<Response<Request>> Build(
            HttpRequestMessage httpRequestMessage,
            bool isQos,
            IQoSProvider qosProvider);
    }
}
