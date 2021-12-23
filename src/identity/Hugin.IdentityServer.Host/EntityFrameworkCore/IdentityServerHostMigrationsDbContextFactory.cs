using HuginIdentityServer.IdentityMappingExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HuginIdentityServer.EntityFrameworkCore
{
    public class IdentityServerHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<IdentityServerHostMigrationsDbContext>
    {
        public IdentityServerHostMigrationsDbContext CreateDbContext(string[] args)
        {
            IdentityEntityMappingExtensions.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<IdentityServerHostMigrationsDbContext>().UseMySql(
                configuration.GetConnectionString("Default"),
                ServerVersion.AutoDetect(configuration.GetConnectionString("Default")));

            return new IdentityServerHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
