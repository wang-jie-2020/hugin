using LG.NetCore.Platform.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace LG.NetCore.Platform
{
    [ApiExplorerSettings(GroupName = ApiGroups.Platform)]
    public abstract class BaseController : AbpController
    {
        protected BaseController()
        {
            LocalizationResource = typeof(PlatformResource);
        }
    }
}
