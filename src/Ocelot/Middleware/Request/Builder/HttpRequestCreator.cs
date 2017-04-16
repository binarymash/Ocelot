using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Ocelot.Responses;
using Ocelot.Middleware.Requester.QoS;

namespace Ocelot.Middleware.Request.Builder
{
    public sealed class HttpRequestCreator : IRequestCreator
    {
        public async Task<Response<Request>> Build(
            string httpMethod, 
            string downstreamUrl,
            Stream content, 
            IHeaderDictionary headers,
            QueryString queryString, 
            string contentType, 
            RequestId.RequestId requestId,
            bool isQos,
            IQoSProvider qosProvider)
        {
            var request = await new RequestBuilder()
                .WithHttpMethod(httpMethod)
                .WithDownstreamUrl(downstreamUrl)
                .WithQueryString(queryString)
                .WithContent(content)
                .WithContentType(contentType)
                .WithHeaders(headers)
                .WithRequestId(requestId)
                .WithIsQos(isQos)
                .WithQos(qosProvider)
                .Build();

            return new OkResponse<Request>(request);
        }
    }
}