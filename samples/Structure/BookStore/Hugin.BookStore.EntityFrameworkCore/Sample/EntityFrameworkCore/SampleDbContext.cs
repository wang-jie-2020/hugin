using Hugin.EntityFrameworkCore;
using Hugin.Sample.BookStore;
using Hugin.Sample.Stadiums;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

namespace Hugin.Sample.EntityFrameworkCore
{
    [ConnectionStringName(SampleConsts.DbProperties.ConnectionStringName)]
    public class SampleDbContext : HuginDbContext<SampleDbContext>
    {
        #region Samples

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<BookShop> BookShops { get; set; }

        public DbSet<BookInBookShop> BookInBookShops { get; set; }

        public DbSet<BookShopOwner> BookShopOwners { get; set; }

        #endregion

        public DbSet<Stadium> Stadiums { get; set; }

        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureSample();
        }
    }
}