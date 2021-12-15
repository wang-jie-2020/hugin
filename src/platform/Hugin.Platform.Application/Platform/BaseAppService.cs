using LG.NetCore.Application.Services;
using LG.NetCore.Platform.Localization;
using Microsoft.AspNetCore.Mvc;

namespace LG.NetCore.Platform
{
    [ApiExplorerSettings(GroupName = ApiGroups.Platform)]
    public abstract class BaseAppService : LGAppService
    {
        protected BaseAppService()
        {
            LocalizationResource = typeof(PlatformResource);
            ObjectMapperContext = typeof(PlatformApplicationModule);
        }
    }
}
