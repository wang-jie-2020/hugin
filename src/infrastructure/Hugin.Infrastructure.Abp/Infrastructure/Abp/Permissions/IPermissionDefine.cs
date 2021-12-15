using Volo.Abp.MultiTenancy;

namespace LG.NetCore.Infrastructure.Abp.Permissions
{
    public interface IPermissionDefine
    {
        MultiTenancySides MultiTenancySide { get; }
    }
}
