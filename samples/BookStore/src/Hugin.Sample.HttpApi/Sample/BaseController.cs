using LG.NetCore.Sample.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace LG.NetCore.Sample
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
