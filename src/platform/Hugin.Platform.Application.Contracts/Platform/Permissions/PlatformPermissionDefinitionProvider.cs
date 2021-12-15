using System.Reflection;
using LG.NetCore.Platform.Localization;
using Volo.Abp.Localization;
using PermissionDefinitionProvider = LG.NetCore.Application.Permissions.PermissionDefinitionProvider;

namespace LG.NetCore.Platform.Permissions
{
    public class PlatformPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        protected override LocalizableString L(string name)
        {
            return LocalizableString.Create<PlatformResource>("Permission:" + name);
        }

        protected override string RootPermission => PlatformPermissions.RootName;

        protected override Assembly[] Assemblies => new[] { typeof(PlatformPermissionDefinitionProvider).Assembly };
    }
}