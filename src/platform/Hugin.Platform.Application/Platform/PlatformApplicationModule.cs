using LG.NetCore.Infrastructure.Exporting;
using LG.NetCore.Infrastructure.Exporting.impl;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace LG.NetCore.Platform
{
    [DependsOn(
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(PlatformDomainModule),
        typeof(PlatformApplicationContractsModule),
        typeof(PlatformBackgroundJobModule),
        typeof(PlatformCapModule)
        )]
    public class PlatformApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<PlatformApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<PlatformApplicationModule>();
            });

            context.Services.AddTransient<IExcelExporting, ExcelExporting>();
        }
    }
}
