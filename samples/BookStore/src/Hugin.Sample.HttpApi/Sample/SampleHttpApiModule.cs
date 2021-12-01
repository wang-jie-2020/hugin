using LG.NetCore.Sample.Localization;
using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace LG.NetCore.Sample
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcModule),
        typeof(SampleApplicationContractsModule)
        )]
    public class SampleHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(SampleHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<SampleResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
