using System.Threading.Tasks;

namespace LG.NetCore.Sample.BookStore
{
    public interface IBookStoreEvent
    {
        Task PublishEventAsync();
    }
}

