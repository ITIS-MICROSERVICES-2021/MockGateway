using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockGateway.Interfaces;

namespace MockGateway.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RedisController : ControllerBase
    {
        private IRedisService Service { get; }

        public RedisController(IRedisService service)
        {
            Service = service;
        }

        [HttpGet]
        [Route("{key}")]
        public async Task<IActionResult> Get(string key)
        {
            var result = await Service.Read(key);
            return Ok(result);
        }
    }
}