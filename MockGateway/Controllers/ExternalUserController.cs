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
        public async Task<IActionResult> Get()
        {
            var result = await ExternalUserService.GetExternalUser();
            return Ok(result);
        }
    }
}