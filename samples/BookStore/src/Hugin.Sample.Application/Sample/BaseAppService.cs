using LG.NetCore.Application.Services;
using LG.NetCore.Sample.Localization;
using Microsoft.AspNetCore.Mvc;

namespace LG.NetCore.Sample
{
    [ApiExplorerSettings(GroupName = ApiGroups.Sample)]
    public abstract class BaseAppService : LGAppService
    {
        protected BaseAppService()
        {
            LocalizationResource = typeof(SampleResource);
            ObjectMapperContext = typeof(SampleApplicationModule);
        }
    }
}
