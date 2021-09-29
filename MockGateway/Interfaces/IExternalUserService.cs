using System.Threading.Tasks;
using MockGateway.DTOs;

namespace MockGateway.Interfaces
{
    public interface IExternalUserService
    {
        Task<ExternalUserDTO> GetExternalUser();
    }
}