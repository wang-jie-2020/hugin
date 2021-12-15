using Hugin.Sample.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Hugin.Sample
{
    [ApiExplorerSettings(GroupName = "sample")]
    public abstract class BaseController : AbpController
    {
        protected BaseController()
        {
            LocalizationResource = typeof(SampleResource);
        }
    }
}
