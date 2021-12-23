using Hugin.Platform;
using Volo.Abp.Modularity;

namespace Hugin.Terminal
{
    [DependsOn(
        typeof(PlatformDomainModule)
    )]
    public class TerminalBackgroundJobModule : AbpModule
    {
    }
}
