﻿using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Ocelot.Middleware.Requester.QoS;
using Ocelot.Responses;

namespace Ocelot.Middleware.Request.Builder
{
    public interface IRequestCreator
    {
        Task<Response<Request>> Build(string httpMethod,
            string downstreamUrl,
            Stream content,
            IHeaderDictionary headers,
            QueryString queryString,
            string contentType,
            RequestId.RequestId requestId,
            bool isQos,
            IQoSProvider qosProvider);
    }
}
