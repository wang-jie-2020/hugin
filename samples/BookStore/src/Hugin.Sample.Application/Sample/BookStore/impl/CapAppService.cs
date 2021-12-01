using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;

namespace LG.NetCore.Sample.BookStore.impl
{
    /*
     * 这个例子演示的是分布式事件操作
     */
    [SwaggerTag("Cap")]
    public class CapAppService : BaseAppService
    {
        private readonly IBookStoreEvent _bookStoreEvent;

        public CapAppService(IBookStoreEvent bookStoreEvent)
        {
            _bookStoreEvent = bookStoreEvent;
        }

        public async Task PublishEventAsync()
        {
            await _bookStoreEvent.PublishEventAsync();
        }
    }
}