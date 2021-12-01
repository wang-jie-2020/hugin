namespace Hugin
{
    public static class Global
    {
        /*
         *  全局（本机）唯一标识
         *  注意：非DEBUG时，不得修改！！！
         */
#if DEBUG
        public const string Identifier = "_debug";
#else
        public const string Identifier = "";
#endif
    }
}
