using System.Collections.Concurrent;
using CSRedis;

namespace LG.NetCore.Infrastructure.Cache.CsRedis
{
    public static class RedisClientFactory
    {
        private static readonly ConcurrentDictionary<string, CSRedisClient> ClientCaches =
            new ConcurrentDictionary<string, CSRedisClient>();

        public static CSRedisClient CreateClient(string connectionString)
        {
            return GetOrAddClient(connectionString);
        }

        private static CSRedisClient GetOrAddClient(string connectionString)
        {
            return ClientCaches.GetOrAdd(connectionString, (key) => new CSRedisClient(key));
        }
    }
}
