using LG.NetCore.Sample.BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LG.NetCore.Sample.EntityFrameworkCore.EntityTypeConfigurations.Samples.BookStore
{
    public class BookShopOwnerConfiguration : IEntityTypeConfiguration<BookShopOwner>
    {
        public void Configure(EntityTypeBuilder<BookShopOwner> builder)
        {
            builder.ToTable(SampleConsts.DbProperties.DbTablePrefix + nameof(BookShopOwner));
            builder.ConfigureByConvention();
        }
    }
}
