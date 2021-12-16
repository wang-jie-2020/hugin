using Hugin.BookStore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Hugin.Sample.EntityFrameworkCore
{
    public class SampleHostMigrationsDbContext : AbpDbContext<SampleHostMigrationsDbContext>
    {
        public SampleHostMigrationsDbContext(DbContextOptions<SampleHostMigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureBookStore();
        }
    }
}