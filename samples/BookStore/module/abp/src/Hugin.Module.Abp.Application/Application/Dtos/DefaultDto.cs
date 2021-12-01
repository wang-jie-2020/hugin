using System;
using Volo.Abp.Application.Dtos;

namespace Hugin.Application.Dtos
{
    public class DefaultDto<TKey> : EntityDto<TKey>
    {
        public DateTime CreationTime { get; set; }
    }
}
