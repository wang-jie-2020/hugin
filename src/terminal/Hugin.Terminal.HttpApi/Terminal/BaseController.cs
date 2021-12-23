﻿using HostShared;
using Hugin.Platform.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Hugin.Terminal
{
    [ApiExplorerSettings(GroupName = ApiGroups.Terminal)]
    public abstract class BaseController : AbpController
    {
        protected BaseController()
        {
            LocalizationResource = typeof(PlatformResource);
        }
    }
}
