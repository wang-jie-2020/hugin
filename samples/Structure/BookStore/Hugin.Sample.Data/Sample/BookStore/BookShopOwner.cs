using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace Hugin.Sample.BookStore
{
    /// <summary>
    /// 书店老板
    /// </summary>
    public class BookShopOwner : Entity<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(SampleConsts.Lengths.Small)]
        [Description("名称")]
        public string Name { get; set; }
    }
}
