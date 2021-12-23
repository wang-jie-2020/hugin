using Volo.Abp.Reflection;

namespace Hugin.Platform.Permissions
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