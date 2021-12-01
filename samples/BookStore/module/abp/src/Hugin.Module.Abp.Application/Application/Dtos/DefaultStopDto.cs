using System;

namespace Hugin.Application.Dtos
{
    public class DefaultStopDto<TKey> : StopEntityDto<TKey>
    {
        public DateTime CreationTime { get; set; }
    }
}
