namespace LG.NetCore.Sample
{
    public static partial class SampleConsts
    {
        public static class DbProperties
        {
            public static string DbTablePrefix { get; set; } = SampleConsts.Name + "_";

            public static string DbSchema { get; set; } = null;

            public const string ConnectionStringName = SampleConsts.Name;
        }
    }
}
