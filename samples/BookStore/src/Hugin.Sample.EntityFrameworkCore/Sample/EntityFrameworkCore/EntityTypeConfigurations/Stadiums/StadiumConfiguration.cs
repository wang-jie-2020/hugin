﻿using LG.NetCore.Sample.Stadiums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LG.NetCore.Sample.EntityFrameworkCore.EntityTypeConfigurations.Stadiums
{
    public class StadiumConfiguration : IEntityTypeConfiguration<Stadium>
    {
        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            builder.ToTable(SampleConsts.DbProperties.DbTablePrefix + nameof(Stadium));
            builder.ConfigureByConvention();
        }
    }
}
