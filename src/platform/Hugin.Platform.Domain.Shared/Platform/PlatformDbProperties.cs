namespace Hugin.Platform
{
    public static partial class PlatformConsts
    {
        public static class DbProperties
        {
            public const string ConnectionStringName = PlatformConsts.Name;

            public static string DbTablePrefix { get; set; } = PlatformConsts.NameLower + "_";

            public static string DbSchema { get; set; } = null;
        }
    }
}
