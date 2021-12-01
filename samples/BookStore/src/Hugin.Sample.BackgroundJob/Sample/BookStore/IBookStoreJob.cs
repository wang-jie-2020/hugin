using System.Threading.Tasks;
using LG.NetCore.Sample.BookStore.Btos;

namespace LG.NetCore.Sample.BookStore
{
    public interface IBookStoreJob
    {
        Task ImmediatelyJobs();

        Task DelayedJobs();

        Task RecurringJobs();

        Task ContinuationJobs();

        Task CheckBookJob(BookJobArgs args);
    }
}

