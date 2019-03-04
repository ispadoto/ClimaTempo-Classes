using Microsoft.Extensions.Caching.Memory;
using System;
using System.Runtime.Caching;

namespace AgroClinic.Infra.CrossCutting.Shared.Utils.BaseClient
{
    public interface ICacheService
    {
        T Get<T>(string cacheKey) where T : class;
        void Set(string cacheKey, object item, int minutes);
    }

    public class InMemoryCache : ICacheService
    {
        public T Get<T>(string cacheKey) where T : class
        {
            return System.Runtime.Caching.MemoryCache.Default.Get(cacheKey) as T;
        }
        public void Set(string cacheKey, object item, int minutes)
        {
            if (item != null)
            {
                System.Runtime.Caching.MemoryCache.Default.Add(cacheKey, item, DateTime.Now.AddMinutes(minutes));
            }
        }
    }
}
