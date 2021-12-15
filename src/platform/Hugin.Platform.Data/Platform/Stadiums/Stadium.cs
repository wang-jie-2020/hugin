﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace LG.NetCore.Platform.Stadiums
{
    /// <summary>
    /// 场馆
    /// </summary>
    public class Stadium : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(PlatformConsts.Lengths.Small)]
        [Description("名称")]
        public string Name { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [Description("租户Id")]
        public Guid? TenantId { get; protected set; }

        private Stadium()
        {

        }

        public Stadium(Guid? tenantId, string name)
        {
            TenantId = tenantId;
            Name = name;
        }
    }
}