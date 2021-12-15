using Hugin.Application.Permissions;
using Hugin.Sample.Permissions;
using Volo.Abp.MultiTenancy;

namespace Hugin.Sample.BookStore.Permissions
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