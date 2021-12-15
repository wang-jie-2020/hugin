using Microsoft.AspNetCore.Http;
using Volo.Abp.Application.Services;
using Volo.Abp.AutoMapper;
using Volo.Abp.EventBus.Local;

namespace LG.NetCore.Infrastructure.Abp.AppServices
{
    public abstract class LGAppService : ApplicationService
    {
        private IHttpContextAccessor _httpContextAccessor;
        protected IHttpContextAccessor HttpContextAccessor => this.LazyGetRequiredService<IHttpContextAccessor>(ref this._httpContextAccessor);

        protected HttpContext HttpContext => HttpContextAccessor.HttpContext;

        private IMapperAccessor _mapperAccessor;
        protected IMapperAccessor MapperAccessor => this.LazyGetRequiredService<IMapperAccessor>(ref this._mapperAccessor);

        private ILocalEventBus _localEventBus;
        protected ILocalEventBus LocalEventBus => this.LazyGetRequiredService<ILocalEventBus>(ref this._localEventBus);

        protected LGAppService()
        {

        }
    }
}
