using Hugin.Sample.BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Hugin.Sample.EntityFrameworkCore.EntityTypeConfigurations.Samples.BookStore
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable(SampleConsts.DbProperties.DbTablePrefix + nameof(Author));
            builder.ConfigureByConvention();
            builder.HasIndex(x => x.Name);
        }
    }
}
