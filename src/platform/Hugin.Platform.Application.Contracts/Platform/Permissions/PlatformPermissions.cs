using Volo.Abp.Reflection;

namespace LG.NetCore.Platform.Permissions
{
    internal class PlatformPermissions
    {
        public const string RootName = PlatformConsts.Name;

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(PlatformPermissions));
        }
    }
}