using System.Threading.Tasks;
using MockGateway.Interfaces;
using StackExchange.Redis.Extensions.Core.Abstractions;

namespace MockGateway.Services
{
    public class RedisService : IRedisService
    {
        private IRedisDatabase Database { get; }

        public RedisService(IRedisDatabase database)
        {
            Database = database;
        }

        public async Task<string> Read(string key)
        {
            return await Database.GetAsync<string>(key);
        }
    }
}