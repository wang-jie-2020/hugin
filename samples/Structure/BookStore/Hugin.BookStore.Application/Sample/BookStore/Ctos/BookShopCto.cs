using System.Collections.Generic;
using Hugin.BookStore;
using Hugin.Sample.BookStore.Daos;
using Volo.Abp.Caching;
using Volo.Abp.MultiTenancy;

namespace Hugin.Sample.BookStore.Ctos
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
