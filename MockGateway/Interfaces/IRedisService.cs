using System.Threading.Tasks;

namespace MockGateway.Interfaces
{
    public interface IRedisService
    {
        Task<string> Read(string key);
    }
}