﻿using System;

namespace Hugin.Oss.Local.@internal
{
    internal class FileRecord
    {
        public string FrId { get; set; }

        /// <summary>
        /// 所属用户
        /// </summary>
        public string FrOwnerUser { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string FrType { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string FrName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FrPath { get; set; }

        /// <summary>
        /// 文件Hash，SHA1
        /// </summary>
        public string FrHash { get; set; }

        /// <summary>
        /// 文件大小，单位B
        /// </summary>
        public string FrSize { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? FrCreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 备注
        /// </summary>
        public string FrRemark { get; set; }
    }
}
