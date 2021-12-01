using System;

namespace LG.NetCore.Sample.BookStore.Btos
{
    public class BookJobArgs
    {
        public Guid BookId { get; set; }

        public string Message => "BookJobArgs";
    }
}