using Hugin.Application.Permissions;
using Hugin.Platform;
using Volo.Abp.MultiTenancy;

namespace Hugin.Terminal.Permissions
{
    public partial class TerminalPermissions : IPermissionDefine
    {
        public static class Group
        {
            public const string Default = PlatformConsts.Name;
        }

        public MultiTenancySides MultiTenancySide { get; } = MultiTenancySides.Tenant;
    }
}
