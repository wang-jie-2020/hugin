using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Hugin.BookStore;
using Hugin.Domain.Entities.Attributes;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Hugin.Sample.EntityFrameworkCore
{
    public static class SampleDbContextModelCreatingExtensions
    {
        public static void ConfigureSample(
            this ModelBuilder builder,
            Action<SampleModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new SampleModelBuilderConfigurationOptions(
                BookStoreConsts.DbProperties.DbTablePrefix,
                BookStoreConsts.DbProperties.DbSchema);

            optionsAction?.Invoke(options);

            #region Samples

            /* Configure all entities here. Example:

                builder.Entity<Question>(b =>
                {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);

                b.ConfigureByConvention();

                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
                });
            */

            #endregion

            //configurations
            builder.ApplyConfigurationsFromAssembly(typeof(SampleDbContextModelCreatingExtensions).Assembly);

            //decimal
            foreach (var model in builder.Model.GetEntityTypes())
            {
                var properties = model.ClrType.GetProperties()
                    .Where(c => c.IsDefined(typeof(DecimalPrecisionAttribute), true));

                foreach (var prop in properties)
                {
                    var attr = prop.GetCustomAttribute<DecimalPrecisionAttribute>();
                    builder.Entity(model.ClrType).Property(prop.Name).HasColumnType($"decimal({attr.Precision},{attr.Scale})");
                }
            }

            //comment
            foreach (var model in builder.Model.GetEntityTypes())
            {
                var properties = model.ClrType.GetProperties()
                    .Where(c => c.IsDefined(typeof(DescriptionAttribute), true));

                foreach (var prop in properties)
                {
                    if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                    {
                        continue;
                    }

                    var attr = prop.GetCustomAttribute<DescriptionAttribute>();
                    builder.Entity(model.ClrType).Property(prop.Name).HasComment(attr.Description);
                }
            }
        }
    }
}