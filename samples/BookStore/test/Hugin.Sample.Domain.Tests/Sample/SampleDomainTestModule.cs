using LG.NetCore.Sample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LG.NetCore.Sample
{
    [DependsOn(
        typeof(SampleEntityFrameworkCoreTestModule)
        )]
    public class SampleDomainTestModule : AbpModule
    {

    }
}
