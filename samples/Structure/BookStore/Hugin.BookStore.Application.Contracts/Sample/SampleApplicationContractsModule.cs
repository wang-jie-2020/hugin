using Hugin.BookStore;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Hugin.Sample
{
    [DependsOn(
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule),
        typeof(BookStoreDomainSharedModule)
        )]
    public class SampleApplicationContractsModule : AbpModule
    {

    }
}
