using Hugin.Domain.Manager;

namespace Hugin.Sample
{
    public abstract class BaseDomainManager : HuginDomainManager
    {
        protected BaseDomainManager()
        {
            ObjectMapperContext = typeof(SampleDomainModule);
        }
    }
}
