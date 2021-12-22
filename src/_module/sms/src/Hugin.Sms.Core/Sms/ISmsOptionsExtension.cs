using Microsoft.Extensions.DependencyInjection;

namespace LG.NetCore.Sms
{
    public interface ISmsOptionsExtension
    {
        void AddServices(IServiceCollection services);
    }
}
