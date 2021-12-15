using LG.NetCore.Platform.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LG.NetCore.Platform
{
    [DependsOn(
        typeof(PlatformEntityFrameworkCoreTestModule)
        )]
    public class PlatformDomainTestModule : AbpModule
    {

    }
}
