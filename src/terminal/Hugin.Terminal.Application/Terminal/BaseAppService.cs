using LG.NetCore.Application.Services;
using LG.NetCore.Platform.Localization;
using Microsoft.AspNetCore.Mvc;

namespace LG.NetCore.Terminal
{
    [ApiExplorerSettings(GroupName = ApiGroups.Terminal)]
    public abstract class BaseAppService : LGAppService
    {
        protected BaseAppService()
        {
            LocalizationResource = typeof(PlatformResource);
            ObjectMapperContext = typeof(TerminalApplicationModule);
        }
    }
}
