using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MockGateway.Application.Features.GetExternalUserInfo;

namespace MockGateway.Domain.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ExternalUserController : ControllerBase
    {
        private IMediator Mediator { get; }

        public ExternalUserController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetExternalUser()
        {
            var query = new GetExternalUserInfoQuery();
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}