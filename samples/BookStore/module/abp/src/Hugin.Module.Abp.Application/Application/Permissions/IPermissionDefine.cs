using Volo.Abp.MultiTenancy;

namespace LG.NetCore.Application.Permissions
{
    public interface IPermissionDefine
    {
        MultiTenancySides MultiTenancySide { get; }
    }
}
