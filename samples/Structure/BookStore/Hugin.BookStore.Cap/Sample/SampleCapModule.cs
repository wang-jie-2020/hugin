using Hugin.BookStore;
using Volo.Abp.Modularity;

namespace Hugin.Sample
{
    [DependsOn(
        typeof(BookShopDomainModule)
    )]
    public class SampleCapModule : AbpModule
    {

    }
}
