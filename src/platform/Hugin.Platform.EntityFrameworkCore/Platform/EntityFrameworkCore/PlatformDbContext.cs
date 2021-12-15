using LG.NetCore.EntityFrameworkCore;
using LG.NetCore.Platform.Stadiums;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

namespace LG.NetCore.Platform.EntityFrameworkCore
{
    [ConnectionStringName(PlatformConsts.DbProperties.ConnectionStringName)]
    public class PlatformDbContext : LGDbContext<PlatformDbContext>
    {
        public DbSet<Stadium> Stadiums { get; set; }

        public PlatformDbContext(DbContextOptions<PlatformDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigurePlatform();
        }
    }
}