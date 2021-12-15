using Volo.Abp.Modularity;

namespace LG.NetCore.Platform
{
    [DependsOn(
        typeof(PlatformDomainModule)
    )]
    public class PlatformCapModule : AbpModule
    {

    }
}
