using Volo.Abp.Reflection;

namespace Hugin.Sample.Permissions
{
    internal class SamplePermissions
    {
        public const string RootName = SampleConsts.Name;

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(SamplePermissions));
        }
    }
}