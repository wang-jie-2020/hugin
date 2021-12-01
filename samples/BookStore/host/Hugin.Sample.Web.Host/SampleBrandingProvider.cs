using LG.NetCore.Sample;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LG.NetCore.Web
{
    [Dependency(ReplaceServices = true)]
    public class SampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => SampleConsts.Name;
    }
}
