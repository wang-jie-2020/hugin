using Hugin.BookStore;
using Hugin.Sample.BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Hugin.Sample.EntityFrameworkCore.EntityTypeConfigurations.Samples.BookStore
{
    public class BookShopOwnerConfiguration : IEntityTypeConfiguration<BookShopOwner>
    {
        public void Configure(EntityTypeBuilder<BookShopOwner> builder)
        {
            builder.ToTable(BookStoreConsts.DbProperties.DbTablePrefix + nameof(BookShopOwner));
            builder.ConfigureByConvention();
        }
    }
}
