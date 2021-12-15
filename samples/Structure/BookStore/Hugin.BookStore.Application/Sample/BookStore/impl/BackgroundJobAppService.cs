using System;
using System.Threading.Tasks;
using Hugin.Sample.BookStore.Btos;
using Swashbuckle.AspNetCore.Annotations;

namespace Hugin.Sample.BookStore.impl
{
    /*
     * 这个例子演示的是后台作业&后台任务
     */
    [SwaggerTag("作业")]
    public class BackgroundJobAppService : BaseAppService
    {
        private readonly IBookStoreJob _bookStoreJob;

        public BackgroundJobAppService(IBookStoreJob bookStoreJob)
        {
            _bookStoreJob = bookStoreJob;
        }

        public async Task ImmediatelyJobs()
        {
            await _bookStoreJob.ImmediatelyJobs();
        }

        public async Task DelayedJobs()
        {
            await _bookStoreJob.DelayedJobs();
        }

        public async Task RecurringJobs()
        {
            await _bookStoreJob.RecurringJobs();
        }

        public async Task ContinuationJobs()
        {
            await _bookStoreJob.ContinuationJobs();
        }

        public async Task UowWork()
        {
            await _bookStoreJob.CheckBookJob(new BookJobArgs
            {
                BookId = new Guid("53ADE93E-5B6E-407C-A0D2-9ED0C05EDA29")
            });
        }
    }
}