using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Hugin.IdentityServer.Controllers
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
        public int Authorize()
        {
            return 1;
        }
    }
}