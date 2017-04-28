using System.Net.Http;
using System.Threading.Tasks;
using Ocelot.Middleware.DownstreamRequestSender.QoS;
using Ocelot.Responses;

namespace Ocelot.Middleware.Request.Builder
{
    public sealed class HttpRequestCreator : IRequestCreator
    {
        public async Task<Response<Request>> Build(
            HttpRequestMessage httpRequestMessage,
            bool isQos,
            IQoSProvider qosProvider)
        {
            return new OkResponse<Request>(new Request(httpRequestMessage, isQos, qosProvider));
        }
    }
}