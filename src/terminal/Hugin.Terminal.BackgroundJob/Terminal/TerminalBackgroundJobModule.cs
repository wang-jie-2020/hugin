using LG.NetCore.Platform;
using Volo.Abp.Modularity;

namespace LG.NetCore.Terminal
{
    [DependsOn(
        typeof(PlatformDomainModule)
    )]
    public class TerminalBackgroundJobModule : AbpModule
    {
    }
}
