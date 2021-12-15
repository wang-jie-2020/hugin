using LG.NetCore.Platform.Localization;
using System.Reflection;
using Volo.Abp.Localization;
using PermissionDefinitionProvider = LG.NetCore.Application.Permissions.PermissionDefinitionProvider;

namespace LG.NetCore.Terminal.Permissions
{
    public class TerminalPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        protected override LocalizableString L(string name)
        {
            return LocalizableString.Create<PlatformResource>("Permission:" + name);
        }

        protected override string RootPermission => TerminalPermissions.RootName;

        protected override Assembly[] Assemblies => new[] { typeof(TerminalPermissionDefinitionProvider).Assembly };
    }
}