using System;

namespace LG.NetCore.Sample.BookStore.Btos
{
    public class BookShopJobArgs
    {
        public Guid BookId { get; set; }

        public Guid BookShopId { get; set; }

        public string Message => "BookShopJobArgs";
    }
}
