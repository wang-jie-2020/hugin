using LG.NetCore.Platform;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace LG.NetCore.Terminal
{
    [DependsOn(
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule),
        typeof(PlatformDomainSharedModule)
        )]
    public class TerminalApplicationContractsModule : AbpModule
    {

    }
}
