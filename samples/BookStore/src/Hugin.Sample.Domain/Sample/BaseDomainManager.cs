using LG.NetCore.Domain.Manager;

namespace LG.NetCore.Sample
{
    public abstract class BaseDomainManager : LGAppManager
    {
        protected BaseDomainManager()
        {
            ObjectMapperContext = typeof(SampleDomainModule);
        }
    }
}
