using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace LG.NetCore.Platform
{
    [DependsOn(
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule),
        typeof(PlatformDomainSharedModule)
        )]
    public class PlatformApplicationContractsModule : AbpModule
    {

    }
}
