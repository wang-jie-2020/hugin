using LG.NetCore.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Volo.Abp;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LG.NetCore.Infrastructure.Abp.Permissions
{
    /*
     * 设计上按照三层权限组织的，例:
     *  platform    --- root
     *      bookstore   --- group
     *          book    --- child group
     *              create、edit etc --- operation
     *          author  --- child group    
     *              create、edit etc --- operation
     */
    public abstract class PermissionDefinitionProvider : Volo.Abp.Authorization.Permissions.PermissionDefinitionProvider
    {
        public IServiceProvider ServiceProvider { get; set; }

        protected abstract LocalizableString L(string name);

        protected abstract string RootPermission { get; }

        protected abstract Assembly[] Assemblies { get; }

        public override void Define(IPermissionDefinitionContext context)
        {
            var root = context.AddGroup(RootPermission, L(RootPermission));

            var permissions = ReflectionHelper.GetImplementsFromAssembly<IPermissionDefine>(Assemblies);
            foreach (var permission in permissions)
            {
                var instance = (IPermissionDefine)Activator.CreateInstance(permission);
                var list = GetPermissionDefineFields(permission);

                var group = list.SingleOrDefault(field =>
                    field.ReflectedType is { } &&
                    field.ReflectedType.Name.Equals("Group", StringComparison.CurrentCultureIgnoreCase) &&
                    field.Name.Equals("Default", StringComparison.CurrentCultureIgnoreCase));

                if (group == null)
                {
                    throw new AbpException("Cannot find GroupPermission");
                }

                var groupPermission = root.AddPermission(
                    name: group.GetValue(null).ToString(),
                    displayName: L(group.GetValue(null).ToString().Replace(root.Name + ".", "")),
                    instance.MultiTenancySide);

                var childGroups = list.Where(field =>
                    field.ReflectedType is { } &&
                    !field.ReflectedType.Name.Equals("Group", StringComparison.CurrentCultureIgnoreCase) &&
                    field.Name.Equals("Default", StringComparison.CurrentCultureIgnoreCase));

                foreach (var childGroup in childGroups)
                {
                    var childGroupPermission = groupPermission.AddChild(
                       name: childGroup.GetValue(null).ToString(),
                       displayName: L(childGroup.GetValue(null).ToString().Replace(groupPermission.Name + ".", "")),
                       instance.MultiTenancySide);

                    var operations = list.Where(field =>
                        field.ReflectedType == childGroup.ReflectedType &&
                        !field.Name.Equals("Default", StringComparison.CurrentCultureIgnoreCase));

                    foreach (var operation in operations)
                    {
                        childGroupPermission.AddChild(
                            name: operation.GetValue(null).ToString(),
                            displayName: L(operation.GetValue(null).ToString().Replace(childGroupPermission.Name + ".", "")),
                            instance.MultiTenancySide);
                    }
                }
            }
        }

        private List<FieldInfo> GetPermissionDefineFields(Type type)
        {
            var result = new List<FieldInfo>();
            Recursively(result, type, 1);
            return result;
        }

        private void Recursively(List<FieldInfo> result, Type type, int depth = 1)
        {
            if (depth > 2)
            {
                return;
            }

            result.AddRange(type.GetFields(bindingAttr: BindingFlags.Static |
                                           BindingFlags.Public |
                                           BindingFlags.FlattenHierarchy)
                                    .Where<FieldInfo>((Func<FieldInfo, bool>)(x => x.IsLiteral && !x.IsInitOnly)));

            foreach (var nestedType in type.GetNestedTypes(BindingFlags.Public))
            {
                Recursively(result, nestedType, depth + 1);
            }
        }
    }
}