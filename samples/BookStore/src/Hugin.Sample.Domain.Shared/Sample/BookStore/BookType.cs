using System.ComponentModel;

namespace LG.NetCore.Sample.BookStore
{
    public enum BookType
    {
        [Description("未定义")]
        Undefined,

        [Description("冒险")]
        Adventure,

        [Description("奇幻")]
        Fantastic,

        [Description("恐怖")]
        Horror,

        [Description("科学")]
        Science
    }
}
