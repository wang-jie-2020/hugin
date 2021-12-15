using Hugin.Domain.Manager;

namespace Hugin.Sample
{
    public abstract class BaseDomainManager : LGAppManager
    {
        protected BaseDomainManager()
        {
            ObjectMapperContext = typeof(SampleDomainModule);
        }
    }
}
