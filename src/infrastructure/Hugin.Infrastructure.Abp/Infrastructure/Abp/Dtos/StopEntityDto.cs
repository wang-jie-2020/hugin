using Volo.Abp.Application.Dtos;

namespace LG.NetCore.Infrastructure.Abp.Dtos
{
    public abstract class StopEntityDto<TKey> : EntityDto<TKey>
    {
        public virtual bool IsStop { get; set; }
    }

    public abstract class StopEntityDto : EntityDto
    {
        public virtual bool IsStop { get; set; }
    }
}
