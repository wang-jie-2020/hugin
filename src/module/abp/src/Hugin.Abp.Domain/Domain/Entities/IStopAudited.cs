using System;

namespace LG.NetCore.Domain.Entities
{
    public interface IStopAudited : IStop
    {
        Guid? StopUserId { get; set; }

        DateTime? StopTime { get; set; }
    }
}
