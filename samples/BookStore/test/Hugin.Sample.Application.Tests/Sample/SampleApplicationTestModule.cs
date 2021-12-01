using Volo.Abp.Modularity;

namespace LG.NetCore.Sample
{
    [DependsOn(
        typeof(SampleApplicationModule),
        typeof(SampleDomainTestModule)
    )]
    public class SampleApplicationTestModule : AbpModule
    {

    }
}
