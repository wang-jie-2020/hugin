﻿using System;

namespace LG.NetCore.Sample.BookStore.Etos
{
    public class BookShopEventArgs
    {
        public int ThreadId { get; set; }

        public Guid BookId { get; set; }

        public Guid BookShopId { get; set; }

        public string Message => "BookShopJobArgs";
    }
}
