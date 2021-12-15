using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LG.NetCore.Platform.EntityFrameworkCore
{
    [ConnectionStringName(PlatformConsts.DbProperties.ConnectionStringName)]
    public interface IPlatformDbContext : IEfCoreDbContext
    {
    }
}