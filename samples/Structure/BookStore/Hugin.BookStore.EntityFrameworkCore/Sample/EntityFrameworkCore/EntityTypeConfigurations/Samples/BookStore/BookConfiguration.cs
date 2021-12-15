using Hugin.Sample.BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Hugin.Sample.EntityFrameworkCore.EntityTypeConfigurations.Samples.BookStore
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable(SampleConsts.DbProperties.DbTablePrefix + nameof(Book));
            builder.ConfigureByConvention();
        }
    }
}
