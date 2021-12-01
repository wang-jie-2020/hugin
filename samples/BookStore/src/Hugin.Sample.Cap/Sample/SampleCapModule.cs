using Volo.Abp.Modularity;

namespace LG.NetCore.Sample
{
    [DependsOn(
        typeof(SampleDomainModule)
    )]
    public class SampleCapModule : AbpModule
    {

    }
}
