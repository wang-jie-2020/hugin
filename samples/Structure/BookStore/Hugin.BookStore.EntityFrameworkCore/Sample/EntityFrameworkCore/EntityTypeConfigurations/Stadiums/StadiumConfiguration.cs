﻿using Hugin.BookStore;
using Hugin.Stadiums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Hugin.Sample.EntityFrameworkCore.EntityTypeConfigurations.Stadiums
{
    public class StadiumConfiguration : IEntityTypeConfiguration<Stadium>
    {
        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            builder.ToTable(BookStoreConsts.DbProperties.DbTablePrefix + nameof(Stadium));
            builder.ConfigureByConvention();
        }
    }
}
