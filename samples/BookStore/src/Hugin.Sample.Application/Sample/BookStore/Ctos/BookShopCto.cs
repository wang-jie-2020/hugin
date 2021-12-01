using System.Collections.Generic;
using LG.NetCore.Sample.BookStore.Daos;
using Volo.Abp.Caching;
using Volo.Abp.MultiTenancy;

namespace LG.NetCore.Sample.BookStore.Ctos
{
    /// <summary>
    /// BookShop Cache
    /// </summary>
    [CacheName("BookShopCache")]
    [IgnoreMultiTenancy]
    public class BookShopCto
    {
        public BookShop BookShop { get; set; }

        public IEnumerable<BookDao> Books { get; set; }

        public BookShopOwner BookShopOwner { get; set; }
    }
}
