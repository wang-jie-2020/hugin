using LG.NetCore.Sample.BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LG.NetCore.Sample.EntityFrameworkCore.EntityTypeConfigurations.Samples.BookStore
{
    public class BookShopConfiguration : IEntityTypeConfiguration<BookShop>
    {
        public void Configure(EntityTypeBuilder<BookShop> builder)
        {
            builder.ToTable(SampleConsts.DbProperties.DbTablePrefix + nameof(BookShop));
            builder.ConfigureByConvention();
        }
    }
}
