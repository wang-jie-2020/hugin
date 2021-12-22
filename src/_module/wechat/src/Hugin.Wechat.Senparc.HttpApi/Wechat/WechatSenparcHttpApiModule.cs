using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace LG.NetCore.Wechat
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcModule),
        typeof(WechatSenparcModule))]
    public class WechatSenparcHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(WechatSenparcHttpApiModule).Assembly);
            });
        }
    }
}