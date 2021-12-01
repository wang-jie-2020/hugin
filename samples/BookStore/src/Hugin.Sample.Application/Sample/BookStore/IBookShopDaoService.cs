using System.Linq;
using LG.NetCore.Sample.BookStore.Daos;
using Volo.Abp.DependencyInjection;

namespace LG.NetCore.Sample.BookStore
{
    public interface IBookShopDaoService : ITransientDependency
    {
        IQueryable<BookShopDao> QueryBookShop();
    }
}
