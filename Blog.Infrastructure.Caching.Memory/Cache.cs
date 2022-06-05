﻿namespace Blog.Infrastructure.Caching.Memory
{
    using Blog.WebUI.Infrastructure.Cache;
    using Microsoft.Extensions.Caching.Memory;
    using System;

    public class Cache : ICache
    {
        private IMemoryCache memoryCache;

        public Cache(IMemoryCache _memoryCache)
        {
            memoryCache = _memoryCache;
        }

        public bool TryGetValue(string key, out object value)
        {
            return memoryCache.TryGetValue(key, out value);
        }

        public void Set(string key, object value, int minutesToCache)
        {
            var cacheExpOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddDays(minutesToCache),
                Priority = CacheItemPriority.Normal
            };

            memoryCache.Set(key, value, cacheExpOptions);
        }

        public void Remove(string key)
        {
            memoryCache.Remove(key);
        }
    }
}
