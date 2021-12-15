using System.Threading.Tasks;

namespace LG.NetCore.Infrastructure.Abp.AppServices
{
    public interface IStopAppService<in TKey>
    {
        Task Stop(TKey id);

        Task CancelStop(TKey id);
    }
}