using System.Reflection;
using LG.NetCore.Sample.Localization;
using Volo.Abp.Localization;
using PermissionDefinitionProvider = LG.NetCore.Application.Permissions.PermissionDefinitionProvider;

namespace LG.NetCore.Sample.Permissions
{
    public class SamplePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        protected override LocalizableString L(string name)
        {
            return LocalizableString.Create<SampleResource>("Permission:" + name);
        }

        protected override string RootPermission => SamplePermissions.RootName;

        protected override Assembly[] Assemblies => new[] { typeof(SamplePermissionDefinitionProvider).Assembly };

        public override void Define(Volo.Abp.Authorization.Permissions.IPermissionDefinitionContext context)
        {
            base.Define(context);

            //var group = context.AddGroup("Sample.PermissionTest");
            //var child = group.AddPermission("Sample.PermissionTest.Child");
        }
    }
}