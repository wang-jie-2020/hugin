﻿using System.Collections.Generic;
using System.Linq;

namespace LG.NetCore.Infrastructure.Extensions
{
    public static class CollectionsExtensions
    {
        /// <summary>
        /// 集合是否为空
        /// </summary>
        /// <param name="source"> 要处理的集合 </param>
        /// <typeparam name="T"> 动态类型 </typeparam>
        /// <returns> 为空返回True，不为空返回False </returns>
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        /// <summary>
        /// 集合是否为空
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsEmpty<T>(this IQueryable<T> source)
        {
            return source == null || !source.Any();
        }

        ///// <summary>
        ///// 把IQueryable[T]集合按指定属性与排序方式进行排序
        ///// </summary>
        ///// <param name="source">要排序的数据集</param>
        ///// <param name="propertyName">排序属性名</param>
        ///// <param name="sortDirection">排序方向</param>
        ///// <typeparam name="T">动态类型</typeparam>
        ///// <returns>排序后的数据集</returns>
        //public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string propertyName, ListSortDirection sortDirection = ListSortDirection.Ascending)
        //{
        //    return QueryableHelper<T>.OrderBy(source, propertyName, sortDirection);
        //}

        ///// <summary>
        ///// 把IQueryable[T]集合按指定属性排序条件进行排序
        ///// </summary>
        ///// <typeparam name="T">动态类型</typeparam>
        ///// <param name="source">要排序的数据集</param>
        ///// <param name="propertySort">列表属性排序条件</param>
        ///// <returns></returns>
        //public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, PropertySort propertySort)
        //{
        //    return source.OrderBy(propertySort.PropertyName, propertySort.SortDirection);
        //}

        ///// <summary>
        ///// 把IOrderedQueryable[T]集合继续按指定属性排序方式进行排序
        ///// </summary>
        ///// <typeparam name="T">动态类型</typeparam>
        ///// <param name="source">要排序的数据集</param>
        ///// <param name="propertyName">排序属性名</param>
        ///// <param name="sortDirection">排序方向</param>
        ///// <returns></returns>
        //public static IOrderedQueryable<T> ThenBy<T>(this IOrderedQueryable<T> source, string propertyName, ListSortDirection sortDirection = ListSortDirection.Ascending)
        //{
        //    return QueryableHelper<T>.ThenBy(source, propertyName, sortDirection);
        //}

        ///// <summary>
        ///// 把IOrderedQueryable[T]集合继续指定属性排序方式进行排序
        ///// </summary>
        ///// <typeparam name="T">动态类型</typeparam>
        ///// <param name="source">要排序的数据集</param>
        ///// <param name="propertySort">列表属性排序条件</param>
        ///// <returns></returns>
        //public static IOrderedQueryable<T> ThenBy<T>(this IOrderedQueryable<T> source, PropertySort propertySort)
        //{
        //    return source.ThenBy(propertySort.PropertyName, propertySort.SortDirection);
        //}

        ///// <summary>
        ///// 从指定IQueryable[T]集合 中查询指定分页条件的子数据集
        ///// </summary>
        ///// <typeparam name="T">动态实体类型</typeparam>
        ///// <param name="source">要查询的数据集</param>
        ///// <param name="predicate">查询条件谓语表达式</param>
        ///// <param name="pageIndex">分页索引</param>
        ///// <param name="pageSize">分页大小</param>
        ///// <param name="total">输出符合条件的总记录数</param>
        ///// <param name="propertySorts">排序条件集合</param>
        ///// <returns></returns>
        //public static IQueryable<T> Page<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate, int pageIndex, int pageSize,
        //    out int total, PropertySort[] propertySorts = null)
        //{
        //    total = source.Count(predicate);
        //    if (IsEmpty(propertySorts))
        //    {
        //        source = source.OrderBy(m => true);
        //    }
        //    else
        //    {
        //        int count = 0;
        //        IOrderedQueryable<T> orderSource = null;
        //        foreach (var sort in propertySorts)
        //        {
        //            orderSource = count == 0
        //                ? source.OrderBy(sort.PropertyName, sort.SortDirection)
        //                : orderSource.ThenBy(sort.PropertyName, sort.SortDirection);

        //            count++;
        //        }
        //        source = orderSource;
        //    }

        //    return source == null
        //        ? Enumerable.Empty<T>().AsQueryable()
        //        : source.Where(predicate).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        //}

        //private static class QueryableHelper<T>
        //{
        //    private static readonly ConcurrentDictionary<string, LambdaExpression> cache = new ConcurrentDictionary<string, LambdaExpression>();

        //    internal static IOrderedQueryable<T> OrderBy(IQueryable<T> source, string propertyName, ListSortDirection sortDirection)
        //    {
        //        dynamic keySelector = GetLambdaExpression(propertyName);
        //        return sortDirection == ListSortDirection.Ascending
        //            ? Queryable.OrderBy(source, keySelector)
        //            : Queryable.OrderByDescending(source, keySelector);
        //    }

        //    internal static IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> source, string propertyName, ListSortDirection sortDirection)
        //    {
        //        dynamic keySelector = GetLambdaExpression(propertyName);
        //        return sortDirection == ListSortDirection.Ascending
        //            ? Queryable.ThenBy(source, keySelector)
        //            : Queryable.ThenByDescending(source, keySelector);
        //    }

        //    private static LambdaExpression GetLambdaExpression(string propertyName)
        //    {
        //        if (cache.ContainsKey(propertyName))
        //        {
        //            return cache[propertyName];
        //        }
        //        ParameterExpression param = Expression.Parameter(typeof(T));
        //        MemberExpression body = Expression.Property(param, propertyName);
        //        LambdaExpression keySelector = Expression.Lambda(body, param);
        //        cache[propertyName] = keySelector;
        //        return keySelector;
        //    }
        //}

    }

    //public class PropertySort
    //{
    //    /// <summary>
    //    /// 构造一个指定属性名称的升序排序的排序条件
    //    /// </summary>
    //    /// <param name="propertyName">排序属性名称</param>
    //    public PropertySort(string propertyName)
    //        : this(propertyName, ListSortDirection.Ascending) { }

    //    /// <summary>
    //    /// 构造一个排序属性名称和排序方式的排序条件
    //    /// </summary>
    //    /// <param name="propertyName">排序属性名称</param>
    //    /// <param name="sortDirection">排序方式</param>
    //    public PropertySort(string propertyName, ListSortDirection sortDirection)
    //    {
    //        PropertyName = propertyName;
    //        SortDirection = sortDirection;
    //    }

    //    /// <summary>
    //    /// 排序属性名称
    //    /// </summary>
    //    public string PropertyName { get; set; }

    //    /// <summary>
    //    /// 排序方向
    //    /// </summary>
    //    public ListSortDirection SortDirection { get; set; }
    //}
}
