using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hugin.BookStore;
using Hugin.BookStore.Dtos;
using Hugin.BookStore.Permissions;
using Hugin.Sample.BookStore.Daos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Hugin.Sample.BookStore.impl
{
    /*
     *  这个例子演示的是abp的crud集成，不完全匹配实际需要
     */
    [ApiExplorerSettings(GroupName = "sample")]
    [SwaggerTag("书籍")]
    //[ExposeServices(typeof(IBookDaoService), IncludeDefaults = true, IncludeSelf = true)]
    public class BookAppService
        : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, BookEditDto>,
            IBookAppService, IBookDaoService
    {
        private readonly IRepository<Book, Guid> _bookRepository;
        private readonly IRepository<Author, Guid> _authorRepository;

        public BookAppService(IRepository<Book, Guid> bookRepository, IRepository<Author, Guid> authorRepository) : base(bookRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;

            GetPolicyName = BookStorePermissions.Book.Default;
            GetListPolicyName = BookStorePermissions.Book.Default;
            CreatePolicyName = BookStorePermissions.Book.Create;
            UpdatePolicyName = BookStorePermissions.Book.Edit;
            DeletePolicyName = BookStorePermissions.Book.Delete;
        }

        public async Task<IEnumerable<BookDto>> GetBookAndAuthor()
        {
            var list = await QueryBook().ToListAsync();
            var result = ObjectMapper.Map<List<BookDao>, List<BookDto>>(list);
            return result;
        }

        /*
         * 这里缺少一个默认查询比如ApplyDefaultSorting(_bookRepository)
         * 返回当前实体查询时默认的筛选条件，比如在有效期、未停用的，也可以包含排序条件
         */

        public IQueryable<BookDao> QueryBook()
        {
            var query = from book in ApplyDefaultSorting(_bookRepository)
                        join author in _authorRepository
                            on book.AuthorId equals author.Id into authorJoined
                        from author in authorJoined.DefaultIfEmpty()
                        select new BookDao
                        {
                            Book = book,
                            Author = author
                        };

            return query;
        }
    }
}
