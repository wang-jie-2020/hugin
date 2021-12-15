using System.Threading.Tasks;

namespace Hugin.Sample.BookStore
{
    public interface IBookStoreEvent
    {
        Task PublishEventAsync();
    }
}

