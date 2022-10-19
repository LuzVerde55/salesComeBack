using System;
using Microsoft.Extensions.Caching.Memory;

namespace SalesCome.Infrastructure.Services.Cache
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _cache;

        public CacheService(IMemoryCache cache)
        {
            this._cache = cache ?? throw new ArgumentNullException(nameof(_cache));
        }

        public void Insert(string key, object obj)
        {
            int min = int.Parse("60000");

            if (key == null || obj == null)
                return;

            _cache.Set(key, obj, DateTime.Now.AddMinutes(min));
        }

        public T Get<T>(string key)
        {
            try
            {
                object dataFound = _cache.Get(key);

                if  (dataFound != null)
                {
                    return (T)dataFound;
                }
                else
                {
                    return default;
                }
            }
            catch
            {
                return default;
            }
        }

        public bool Exist(string key)
        {
            try
            {
                object dataFound = _cache.Get(key);

                if (dataFound != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }
    }
}
