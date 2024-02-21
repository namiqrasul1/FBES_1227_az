
using Microsoft.Extensions.Caching.Distributed;

namespace TestRedisSerilog.Services
{
    public class CacheService : ICacheService
    {
        private readonly IDistributedCache _distributedCache;

        public CacheService(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public Task<T> GetAsync<T>(string key)
        {
            throw new NotImplementedException();
        }

        public Task Remove(string key)
        {
            throw new NotImplementedException();
        }

        public Task<T> SetAsync<T>(string key, T value)
        {
            throw new NotImplementedException();
        }
    }
}
