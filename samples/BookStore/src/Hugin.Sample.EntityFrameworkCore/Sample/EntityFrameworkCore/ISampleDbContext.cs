using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LG.NetCore.Sample.EntityFrameworkCore
{
    [ConnectionStringName(SampleConsts.DbProperties.ConnectionStringName)]
    public interface ISampleDbContext : IEfCoreDbContext
    {
    }
}