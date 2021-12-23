﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace HuginIdentityServer.Controllers
{
    [Route("api/empty/authorize")]
    public class EmptyController : AbpController
    {
        [Authorize]
        [HttpGet]
        public int Authorize()
        {
            return 1;
        }
    }
}
