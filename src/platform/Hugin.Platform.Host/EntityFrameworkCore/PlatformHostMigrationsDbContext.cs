﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LG.NetCore.Platform.EntityFrameworkCore
{
    public class PlatformHostMigrationsDbContext : AbpDbContext<PlatformHostMigrationsDbContext>
    {
        public PlatformHostMigrationsDbContext(DbContextOptions<PlatformHostMigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigurePlatform();
        }
    }
}