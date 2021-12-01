using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace LG.NetCore.Identity
{
    [DependsOn(
        typeof(AbpDddDomainModule)
    )]
    public class IdentityDomainModule : AbpModule
    {

    }
}
