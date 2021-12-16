using System;

namespace Hugin.BookStore.Etos
{
    public class BookErrorEventArgs
    {
        public Guid Id { get; set; }

        public string Message => "Book Error Event";
    }
}
