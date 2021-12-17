using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Hugin.BookStore.Controllers
{
    [Route("api/healthy")]
    public class HealthyController : AbpController
    {
        [Authorize]
        [HttpGet]
        [Route("authorize")]
        public int Authorize()
        {
            return 1;
        }
    }
}
