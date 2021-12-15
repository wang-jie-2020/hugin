using Volo.Abp.Reflection;

namespace LG.NetCore.Terminal.Permissions
{
    internal class TerminalPermissions
    {
        public const string RootName = TerminalConsts.Name;

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(TerminalPermissions));
        }
    }
}