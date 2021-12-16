using Hugin.BookStore;
using Hugin.Stadiums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.MultiStadium;

namespace Hugin
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AbpAutoMapperModule),
        typeof(BookStoreDomainSharedModule)
    )]
    public class SampleDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<SampleDomainModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<SampleDomainModule>(validate: false);
            });

            context.Services.Replace(ServiceDescriptor.Transient<IStadiumStore, StadiumStore>());
        }
    }
}
