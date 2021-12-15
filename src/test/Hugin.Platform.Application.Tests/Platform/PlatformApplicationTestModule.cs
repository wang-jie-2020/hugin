using Volo.Abp.Modularity;

namespace LG.NetCore.Platform
{
    [DependsOn(
        typeof(PlatformApplicationModule),
        typeof(PlatformDomainTestModule)
    )]
    public class PlatformApplicationTestModule : AbpModule
    {

    }
}
