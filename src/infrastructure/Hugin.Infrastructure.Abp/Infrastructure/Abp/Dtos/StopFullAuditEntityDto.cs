using System;
using Volo.Abp.Application.Dtos;

namespace LG.NetCore.Infrastructure.Abp.Dtos
{
    public abstract class StopFullAuditEntityDto<TKey> : FullAuditedEntityDto<TKey>
    {
        public virtual bool IsStop { get; set; }

        public virtual Guid? StopUserId { get; set; }

        public virtual DateTime? StopTime { get; set; }
    }

    public abstract class StopFullAuditEntityDto : FullAuditedEntityDto
    {
        public virtual bool IsStop { get; set; }

        public virtual Guid? StopUserId { get; set; }

        public virtual DateTime? StopTime { get; set; }
    }
}
