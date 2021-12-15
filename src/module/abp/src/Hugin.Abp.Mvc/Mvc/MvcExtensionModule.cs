using LG.NetCore.DependencyInjection;
using LG.NetCore.Mvc.Conventions;
using LG.NetCore.Mvc.ExceptionHandling;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Volo.Abp.AspNetCore.ExceptionHandling;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.AntiForgery;
using Volo.Abp.AspNetCore.Mvc.ApiExploring;
using Volo.Abp.AspNetCore.Mvc.Conventions;
using Volo.Abp.AspNetCore.Mvc.ExceptionHandling;
using Volo.Abp.Modularity;

namespace LG.NetCore.Mvc
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcModule)
    )]
    public class MvcExtensionModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddConventionalRegistrar(new LGDefaultConventionalRegistrar());
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.GetConfiguration();

            Configure<AbpRemoteServiceApiDescriptionProviderOptions>(options =>
            {
                options.SupportedResponseTypes.Clear(); //约定即可
            });

            if (hostingEnvironment.IsDevelopment())
            {
                Configure<AbpExceptionHandlingOptions>(options =>
                {
                    options.SendExceptionsDetailsToClients = true;
                });
            }

            Configure<MvcOptions>(options =>
            {
                options.Filters.Remove(new AbpAutoValidateAntiforgeryTokenAttribute()); //影响带IFormFile的请求，而且也不是很合适
            });

            //重写AbpServiceConvention
            context.Services.Replace(ServiceDescriptor.Transient<IAbpServiceConvention, LGServiceConvention>());

            //替换Abp的错误处理
            context.Services.Replace(ServiceDescriptor.Transient<AbpExceptionFilter, LGExceptionFilter>());

            ////增加结果处理
            //context.Services.AddTransient<LGResultFilter>();
            //Configure<MvcOptions>(options =>
            //{
            //    options.Filters.AddService<LGResultFilter>();
            //});

            //Metadata处理
            //context.Services.Replace(ServiceDescriptor.Singleton<IModelMetadataProvider, LGModelMetadataProvider>());
            //Configure<MvcOptions>(options =>
            //{
            //    options.ModelMetadataDetailsProviders.Add(new LGValidationMetadataProvider());
            //});

            //context.Services.Replace(ServiceDescriptor.Singleton<IValidationAttributeAdapterProvider, LGValidationAttributeAdapterProvider>());
        }
    }
}
