using Hugin.Sample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Hugin.Sample
{
    [DependsOn(
        typeof(SampleEntityFrameworkCoreTestModule)
        )]
    public class SampleDomainTestModule : AbpModule
    {

    }
}
