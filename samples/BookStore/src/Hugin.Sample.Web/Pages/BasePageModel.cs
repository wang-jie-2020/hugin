using LG.NetCore.Sample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LG.NetCore.Sample.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BasePageModel : AbpPageModel
    {
        protected BasePageModel()
        {
            LocalizationResourceType = typeof(SampleResource);
            ObjectMapperContext = typeof(SampleWebModule);
        }
    }
}