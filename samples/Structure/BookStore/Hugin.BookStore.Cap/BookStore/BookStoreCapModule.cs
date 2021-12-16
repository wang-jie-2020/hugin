using Volo.Abp.Modularity;

namespace Hugin.BookStore
{
    [DependsOn(
        typeof(BookShopDomainModule)
    )]
    public class BookStoreCapModule : AbpModule
    {

    }
}
