using Hugin.Sample.BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Hugin.Sample.EntityFrameworkCore.EntityTypeConfigurations.Samples.BookStore
{
    public class BookInBookShopConfiguration : IEntityTypeConfiguration<BookInBookShop>
    {
        public void Configure(EntityTypeBuilder<BookInBookShop> builder)
        {
            builder.ToTable(SampleConsts.DbProperties.DbTablePrefix + nameof(BookInBookShop));
            builder.ConfigureByConvention();
        }
    }
}
