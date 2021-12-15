using LG.NetCore.Infrastructure.Interfaces;
using System;
using System.Reflection;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace LG.NetCore.Infrastructure.Abp.Entities
{
    public static class EntityExtensions
    {
        [Obsolete(message: "See TrySetId", true)]
        public static TEntity SetId<TEntity, TKey>(this TEntity entity, TKey id) where TEntity : class, IEntity<TKey>
        {
            var property = entity.GetType().GetProperty(nameof(entity.Id));
            if (property == null)
            {
                return entity;
            }

            property.SetMethod?.Invoke(entity, new object[] { id });
            return entity;
        }

        public static TEntity TrySetId<TEntity, TKey>(this TEntity entity, TKey id) where TEntity : class, IEntity<TKey>
        {
            EntityHelper.TrySetId(entity, () => id, true);
            return entity;
        }

        public static TEntity TrySetTenantId<TEntity, TKey>(this TEntity entity, TKey tenantId)
        {
            if (!HasTenantIdProperty(entity))
            {
                return entity;
            }

            PropertyInfo property = entity.GetType().GetProperty(nameof(IMultiTenant.TenantId));
            if (property == null || property.GetSetMethod(true) == null)
            {
                return entity;
            }

            property.SetValue(entity, (object)tenantId);
            return entity;
        }

        public static bool HasTenantIdProperty<TEntity>(TEntity entity)
        {
            return entity.GetType().GetProperty(nameof(IMultiTenant.TenantId)) != null;
        }

        public static TEntity TrySetUserId<TEntity, TKey>(this TEntity entity, TKey userId)
        {
            if (!HasUserIdProperty(entity))
            {
                return entity;
            }

            PropertyInfo property = entity.GetType().GetProperty(nameof(IUser.UserId));
            if (property == null || property.GetSetMethod(true) == null)
            {
                return entity;
            }

            property.SetValue(entity, (object)userId);
            return entity;
        }

        public static bool HasUserIdProperty<TEntity>(TEntity entity)
        {
            return entity.GetType().GetProperty(nameof(IUser.UserId)) != null;
        }
    }
}
