using Hugin.Sample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Hugin.Web.Pages
{
    public abstract class BasePageModel : AbpPageModel
    {
        protected BasePageModel()
        {
            LocalizationResourceType = typeof(SampleResource);
        }
    }
}