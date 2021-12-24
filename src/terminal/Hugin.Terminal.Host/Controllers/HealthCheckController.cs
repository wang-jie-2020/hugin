using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Hugin.Terminal.Controllers
{
    [Route("api/healthCheck")]
    public class HealthCheckController : AbpController
    {
        [HttpGet]
        public IActionResult HeathCheck()
        {
            return Ok();
        }

        [Authorize]
        [HttpGet]
        [Route("authorize")]
        public int Authorize()
        {
            return 1;
        }
    }
}