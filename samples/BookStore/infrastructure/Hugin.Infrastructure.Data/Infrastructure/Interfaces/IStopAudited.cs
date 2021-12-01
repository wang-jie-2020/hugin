using System;

namespace Hugin.Infrastructure.Interfaces
{
    public interface IStopAudited
    {
        bool IsStop { get; set; }

        Guid? StopUserId { get; set; }

        DateTime? StopTime { get; set; }
    }
}
