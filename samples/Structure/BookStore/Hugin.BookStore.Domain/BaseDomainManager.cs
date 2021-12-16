using Hugin.Domain.Manager;

namespace Hugin
{
    public abstract class BaseDomainManager : HuginDomainManager
    {
        protected BaseDomainManager()
        {
            ObjectMapperContext = typeof(SampleDomainModule);
        }
    }
}
