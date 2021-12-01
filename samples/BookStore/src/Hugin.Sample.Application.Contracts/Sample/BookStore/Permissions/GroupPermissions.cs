using LG.NetCore.Application.Permissions;
using LG.NetCore.Sample.Permissions;
using Volo.Abp.MultiTenancy;

namespace LG.NetCore.Sample.BookStore.Permissions
{
    /// <summary>
    /// <see cref="SamplePermissionDefinitionProvider"/>
    /// </summary>
    public partial class BookStorePermissions : IPermissionDefine
    {
        public static class Group
        {
            public const string Default = SamplePermissions.RootName + ".BookStore";
        }

        public MultiTenancySides MultiTenancySide { get; } = MultiTenancySides.Both;
    }
}