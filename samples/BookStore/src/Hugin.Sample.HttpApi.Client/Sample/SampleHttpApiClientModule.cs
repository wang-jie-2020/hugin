using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace LG.NetCore.Sample
{
    [DependsOn(
        typeof(AbpHttpClientModule),
        typeof(SampleApplicationContractsModule))]
    public class SampleHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = SampleConsts.Name;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(SampleApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
