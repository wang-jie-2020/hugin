using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Hugin.Sample.EntityFrameworkCore
{
    public class SampleModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public SampleModelBuilderConfigurationOptions([NotNull] string tablePrefix = "", [CanBeNull] string schema = null)
            : base(tablePrefix, schema)
        {

        }
    }
}