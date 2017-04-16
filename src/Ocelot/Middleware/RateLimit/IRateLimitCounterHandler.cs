using System;

namespace Ocelot.Middleware.RateLimit
{
    public interface IRateLimitCounterHandler
    {
        bool Exists(string id);
        RateLimitCounter? Get(string id);
        void Remove(string id);
        void Set(string id, RateLimitCounter counter, TimeSpan expirationTime);
    }
}
