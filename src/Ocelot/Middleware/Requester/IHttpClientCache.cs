using System;

namespace Ocelot.Middleware.Requester
{
    public interface IHttpClientCache
    {
        bool Exists(string id);
        IHttpClient Get(string id);
        void Remove(string id);
        void Set(string id, IHttpClient handler, TimeSpan expirationTime);
    }
}
