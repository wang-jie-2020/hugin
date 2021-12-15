using System.Linq;
using Hugin.Sample.BookStore.Daos;
using Volo.Abp.DependencyInjection;

namespace Hugin.Sample.BookStore
{
    public interface IBookDaoService : ITransientDependency
    {
        IQueryable<BookDao> QueryBook();
    }
}
