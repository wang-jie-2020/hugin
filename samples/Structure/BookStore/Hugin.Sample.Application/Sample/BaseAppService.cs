using Hugin.Application.Services;
using Hugin.Sample.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Hugin.Sample
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
