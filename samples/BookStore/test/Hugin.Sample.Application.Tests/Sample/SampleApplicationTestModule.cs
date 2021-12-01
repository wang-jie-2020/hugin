using Volo.Abp.Modularity;

namespace Hugin.Sample
{
    [DependsOn(
        typeof(SampleApplicationModule),
        typeof(SampleDomainTestModule)
    )]
    public class SampleApplicationTestModule : AbpModule
    {

    }
}
