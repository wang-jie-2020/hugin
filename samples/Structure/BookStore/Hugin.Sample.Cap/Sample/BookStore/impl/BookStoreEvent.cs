using System;
using System.Threading;
using System.Threading.Tasks;
using Hugin.Sample.BookStore.Etos;

namespace Hugin.Sample.BookStore.impl
{

    public class BookStoreEvent : BaseCapEvent, IBookStoreEvent
    {
        public BookStoreEvent()
        {
        }

        public async Task PublishEventAsync()
        {
            await CapPublisher.PublishAsync(EventNameConsts.SampleEvent, new BookShopEventArgs
            {
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                BookId = Guid.NewGuid(),
                BookShopId = Guid.NewGuid()
            });
        }
    }
}