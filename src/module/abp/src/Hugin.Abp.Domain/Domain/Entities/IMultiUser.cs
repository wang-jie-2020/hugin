using System;

namespace LG.NetCore.Domain.Entities
{
    public interface IMultiUser
    {
        Guid? UserId { get; }
    }
}
