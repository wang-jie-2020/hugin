using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LG.NetCore.IdentityServer
{
    [Dependency(ReplaceServices = true)]
    public class ProjectBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LG";
    }
}
