using Hugin.Sample;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Hugin.Web
{
    [Dependency(ReplaceServices = true)]
    public class SampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => SampleConsts.Name;
    }
}
