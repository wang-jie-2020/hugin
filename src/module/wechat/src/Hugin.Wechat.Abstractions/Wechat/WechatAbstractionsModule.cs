using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LG.NetCore.Wechat
{
    public class WechatAbstractionsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IWechatDecryptService, DefaultWechatDecryptService>();
            context.Services.AddTransient<IWechatAuthorizeService, DefaultWechatAuthorizeService>();
        }
    }
}
