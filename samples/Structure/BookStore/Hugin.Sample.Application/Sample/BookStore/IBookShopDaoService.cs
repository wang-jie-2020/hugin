using System.Linq;
using Hugin.Sample.BookStore.Daos;
using Volo.Abp.DependencyInjection;

namespace Hugin.Sample.BookStore
{
    public interface IBookShopDaoService : ITransientDependency
    {
        IQueryable<BookShopDao> QueryBookShop();
    }
}
