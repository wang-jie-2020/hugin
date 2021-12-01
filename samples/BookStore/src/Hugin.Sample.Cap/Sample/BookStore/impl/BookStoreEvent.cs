using System;
using System.Threading;
using System.Threading.Tasks;
using LG.NetCore.Sample.BookStore.Etos;

namespace LG.NetCore.Sample.BookStore.impl
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