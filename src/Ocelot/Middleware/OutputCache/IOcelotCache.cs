using System;

namespace Ocelot.Middleware.OutputCache
{
    public interface IOcelotCache<T>
    {
        void Add(string key, T value, TimeSpan ttl);
        T Get(string key);
    }
}
