using LG.NetCore.Sample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LG.NetCore.Web.Pages
{
    public abstract class BasePageModel : AbpPageModel
    {
        protected BasePageModel()
        {
            LocalizationResourceType = typeof(SampleResource);
        }
    }
}