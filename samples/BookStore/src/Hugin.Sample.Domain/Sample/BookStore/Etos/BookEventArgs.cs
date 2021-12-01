using System;

namespace LG.NetCore.Sample.BookStore.Etos
{
    public class BookEventArgs
    {
        public Guid Id { get; set; }

        public string Message => "Book Event";
    }
}
