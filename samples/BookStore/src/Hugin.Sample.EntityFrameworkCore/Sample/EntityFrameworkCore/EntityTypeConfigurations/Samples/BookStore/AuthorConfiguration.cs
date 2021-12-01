using LG.NetCore.Sample.BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LG.NetCore.Sample.EntityFrameworkCore.EntityTypeConfigurations.Samples.BookStore
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
