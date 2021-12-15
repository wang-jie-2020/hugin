using LG.NetCore.Platform.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace LG.NetCore.Terminal
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
