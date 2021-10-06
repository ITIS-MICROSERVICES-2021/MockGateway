using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockGateway.Interfaces;

namespace MockGateway.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ExternalUserController : ControllerBase
    {
        private IExternalUserService ExternalUserService { get; }

        public ExternalUserController(IExternalUserService externalUserService)
        {
            ExternalUserService = externalUserService;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await ExternalUserService.GetExternalUser(id);
            return result == null ? NotFound() : Ok(result);
        }
    }
}