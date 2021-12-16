using Hugin.Domain.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.MultiTenancy;

namespace Hugin.BookStore
{
    /// <summary>
    /// 书店
    /// </summary>
    public class BookShop : StopFullAuditedAggregateRoot<Guid>, IMultiTenant, IMultiUser
    {
        /// <summary>
        /// 编码
        /// </summary>
        [Required]
        [MaxLength(BookStoreConsts.EntityLengths.Default)]
        [Description("编码")]
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(BookStoreConsts.EntityLengths.Default)]
        [Description("名称")]
        public string Name { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [Description("租户Id")]
        public Guid? TenantId { get; protected set; }

        /// <summary>
        /// Boss
        /// </summary>
        [Description("Boss")]
        public Guid? OwnerId { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        [Description("UserId")]
        public Guid? UserId { get; protected set; }

        /// <summary>
        /// 提供私有构造函数以实现序列化
        /// </summary>
        private BookShop()
        {

        }

        /// <summary>
        /// 不强制要求租户，但要考虑赋值，因为Tenant是只读的
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="userId"></param>
        public BookShop(Guid? tenantId, Guid userId)
        {
            TenantId = tenantId;
            UserId = userId;
        }
    }
}
