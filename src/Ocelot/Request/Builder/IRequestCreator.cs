using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Ocelot.Middleware.RequestId;
using Ocelot.Requester.QoS;
using Ocelot.Responses;

namespace Ocelot.Request.Builder
{
    public interface IRequestCreator
    {
        Task<Response<Request>> Build(string httpMethod,
            string downstreamUrl,
            Stream content,
            IHeaderDictionary headers,
            QueryString queryString,
            string contentType,
            RequestId requestId,
            bool isQos,
            IQoSProvider qosProvider);
    }
}
