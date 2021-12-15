using LG.NetCore.Platform.Stadiums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LG.NetCore.Platform.EntityFrameworkCore.EntityTypeConfigurations.Stadiums
{
    public class StadiumConfiguration : IEntityTypeConfiguration<Stadium>
    {
        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            builder.ToTable(PlatformConsts.DbProperties.DbTablePrefix + nameof(Stadium).ToLower());
            builder.ConfigureByConvention();
        }
    }
}
