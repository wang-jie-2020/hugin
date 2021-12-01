using Volo.Abp.Modularity;

namespace Hugin.Sample
{
    [DependsOn(
        typeof(SampleDomainModule)
    )]
    public class SampleCapModule : AbpModule
    {

    }
}
