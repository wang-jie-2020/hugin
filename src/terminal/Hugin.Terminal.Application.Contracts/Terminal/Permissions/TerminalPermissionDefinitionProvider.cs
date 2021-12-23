using Hugin.Platform.Localization;
using System.Reflection;
using Volo.Abp.Localization;
using PermissionDefinitionProvider = Hugin.Application.Permissions.PermissionDefinitionProvider;

namespace Hugin.Terminal.Permissions
{
    public class TerminalPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        protected override LocalizableString L(string name)
        {
            return LocalizableString.Create<PlatformResource>("Permission:" + name);
        }

        protected override string Root => TerminalPermissions.RootName;

        protected override Assembly[] Assemblies => new[] { typeof(TerminalPermissionDefinitionProvider).Assembly };
    }
}