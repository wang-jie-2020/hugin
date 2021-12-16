using Hugin.BookStore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Hugin.Sample.EntityFrameworkCore
{
    [ConnectionStringName(BookStoreConsts.DbProperties.ConnectionStringName)]
    public interface ISampleDbContext : IEfCoreDbContext
    {
    }
}