using System.Reflection;
using Hugin.Sample.Localization;
using Volo.Abp.Localization;

namespace Hugin.Sample.Permissions
{
    public class SamplePermissionDefinitionProvider : Hugin.Application.Permissions.PermissionDefinitionProvider
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