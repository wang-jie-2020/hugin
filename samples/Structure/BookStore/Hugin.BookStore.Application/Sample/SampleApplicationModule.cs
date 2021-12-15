using Hugin.Infrastructure.Exporting;
using Hugin.Infrastructure.Exporting.impl;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Hugin.Sample
{
    [DependsOn(
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(SampleDomainModule),
        typeof(SampleApplicationContractsModule),
        typeof(SampleBackgroundJobModule),
        typeof(SampleCapModule)
        )]
    public class SampleApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<SampleApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                /*
                 *  validate 检查源、目标间的属性是否一致，通常不会设置true
                 *  若必要则单独增加options.AddProfile < ...> (validate: true or false);
                 */
                options.AddMaps<SampleApplicationModule>(validate: false);
            });

            context.Services.AddTransient<IExcelExporting, ExcelExporting>();
        }
    }
}
