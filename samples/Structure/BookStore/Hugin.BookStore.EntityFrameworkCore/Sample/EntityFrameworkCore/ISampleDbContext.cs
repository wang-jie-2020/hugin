using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Hugin.Sample.EntityFrameworkCore
{
    [ConnectionStringName(SampleConsts.DbProperties.ConnectionStringName)]
    public interface ISampleDbContext : IEfCoreDbContext
    {
    }
}