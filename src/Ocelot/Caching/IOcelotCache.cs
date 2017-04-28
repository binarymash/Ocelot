using System;

namespace Ocelot.Caching
{
    public interface IOcelotCache<T>
    {
        void Add(string key, T value, TimeSpan ttl);
        void AddAndDelete(string key, T value, TimeSpan ttl);
        T Get(string key);
    }
}
