﻿using System;

namespace Hugin.Sample.BookStore.Btos
{
    public class BookJobArgs
    {
        public Guid BookId { get; set; }

        public string Message => "BookJobArgs";
    }
}