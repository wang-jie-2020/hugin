using System.IO;
using Hugin.BookStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Hugin.Sample.EntityFrameworkCore
{
    public class
        SampleHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<
            SampleHostMigrationsDbContext>
    {
        public SampleHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SampleHostMigrationsDbContext>().UseMySql(
                configuration.GetConnectionString(BookStoreConsts.DbProperties.ConnectionStringName),
                ServerVersion.AutoDetect(configuration.GetConnectionString(BookStoreConsts.DbProperties.ConnectionStringName)));

            return new SampleHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false);

            return builder.Build();
        }
    }
}