using Microsoft.Extensions.DependencyInjection;

namespace LG.NetCore.Oss
{
    public interface IOssOptionsExtension
    {
        void AddServices(IServiceCollection services);
    }
}
