using System.Threading.Tasks;
using Hugin.Sample.BookStore.Btos;

namespace Hugin.Sample.BookStore
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

