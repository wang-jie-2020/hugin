using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Z.EntityFramework.Plus;

namespace LG.NetCore.Infrastructure.Abp.Repositories
{
    /// <summary>
    /// 仓储扩展方法类
    /// </summary>
    public static class RepositoryExtensions
    {
        /// <summary>
        /// 按Id新增或更新
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="repository"></param>
        /// <param name="entity"></param>
        /// <param name="autoSave"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<TEntity> InsertOrUpdateAsync<TEntity, TKey>(
            this IRepository<TEntity, TKey> repository,
            TEntity entity,
            bool autoSave = false,
            CancellationToken cancellationToken = default(CancellationToken))
            where TEntity : class, IEntity<TKey>
        {
            var e = await repository.FindAsync(entity.Id, cancellationToken: cancellationToken);

            if (e == null)
            {
                return await repository.InsertAsync(entity, autoSave, cancellationToken: cancellationToken);
            }

            //todo autoMapper?
            new MapperConfiguration(p => { }).CreateMapper().Map(entity, e);
            return await repository.UpdateAsync(e, autoSave, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 仅在不存在时新增
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="repository"></param>
        /// <param name="entity"></param>
        /// <param name="autoSave"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<TEntity> InsertOnlyNotExistAsync<TEntity, TKey>(
            this IRepository<TEntity, TKey> repository,
            TEntity entity,
            bool autoSave = false,
            CancellationToken cancellationToken = default(CancellationToken))
            where TEntity : class, IEntity<TKey>
        {
            var e = await repository.FindAsync(entity.Id, cancellationToken: cancellationToken);

            if (e == null)
            {
                return await repository.InsertAsync(entity, autoSave, cancellationToken: cancellationToken);
            }

            return e;
        }

        /// <summary>
        /// 确定新增（若存在则先删除）
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="repository"></param>
        /// <param name="entity"></param>
        /// <param name="autoSave"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<TEntity> EnsureInsertAsync<TEntity, TKey>(
            this IRepository<TEntity, TKey> repository,
            TEntity entity,
            bool autoSave = false,
            CancellationToken cancellationToken = default(CancellationToken))
            where TEntity : class, IEntity<TKey>
        {
            await repository.DeleteAsync(entity.Id, autoSave, cancellationToken: cancellationToken);
            return await repository.InsertAsync(entity, autoSave, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="repository"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static async Task<int> BatchDeleteAsync<TEntity, TKey>(
            this IRepository<TEntity, TKey> repository,
            Expression<Func<TEntity, bool>> predicate)
            where TEntity : class, IEntity<TKey>
        {
            var query = (IQueryable<TEntity>)repository;
            query = query.Where(predicate);

            return await query.DeleteAsync();
        }

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="repository"></param>
        /// <param name="action"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static async Task<int> BatchUpdateAsync<TEntity, TKey>(
            this IRepository<TEntity, TKey> repository,
            Expression<Func<TEntity, TEntity>> action,
            Expression<Func<TEntity, bool>> predicate)
            where TEntity : class, IEntity<TKey>
        {
            var query = (IQueryable<TEntity>)repository;
            query = query.Where(predicate);

            return await query.UpdateAsync(action);
        }
    }
}