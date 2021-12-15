using System;

namespace LG.NetCore.Application.Dtos
{
    public class DefaultStopDto<TKey> : StopEntityDto<TKey>
    {
        public DateTime CreationTime { get; set; }
    }
}
