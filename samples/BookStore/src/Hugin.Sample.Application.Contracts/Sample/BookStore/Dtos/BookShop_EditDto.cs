using LG.NetCore.Application.Dtos;
using System;
using System.ComponentModel.DataAnnotations;

namespace LG.NetCore.Sample.BookStore.Dtos
{
    public class BookShopEditOutput : IHoused<BookShopEditDto>
    {
        public BookShopEditDto Item { get; set; }
    }

    public class BookShopEditInput : IHoused<BookShopEditDto>
    {
        [Required]
        public BookShopEditDto Item { get; set; }
    }

    public class BookShopEditDto
    {
        /// <summary>
        /// 编码
        /// </summary>
        [Required]
        [MaxLength(SampleConsts.Lengths.Small)]
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(SampleConsts.Lengths.Small)]
        public string Name { get; set; }

        /// <summary>
        /// Boss
        /// </summary>
        public Guid? OwnerId { get; set; }
    }
}