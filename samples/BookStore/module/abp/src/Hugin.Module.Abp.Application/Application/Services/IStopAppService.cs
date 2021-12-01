using System.Threading.Tasks;

namespace LG.NetCore.Application.Services
{
    public interface IStopAppService<in TKey>
    {
        Task Stop(TKey id);

        Task CancelStop(TKey id);
    }
}