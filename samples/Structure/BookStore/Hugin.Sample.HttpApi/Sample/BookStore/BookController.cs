using System;
using System.Threading.Tasks;
using Hugin.Sample.BookStore.Dtos;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Volo.Abp.Application.Dtos;

namespace Hugin.Sample.BookStore
{
    /// <summary>
    /// SampleController
    /// </summary>
    [Route("api/controller/sample/bookstore/book")]
    [SwaggerTag("书籍")]
    public class BookController : BaseController, IBookAppService
    {
        private readonly IBookAppService _bookAppService;

        public BookController(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<BookDto> GetAsync(Guid id)
        {
            return await _bookAppService.GetAsync(id);
        }

        [HttpGet]
        public async Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await _bookAppService.GetListAsync(input);
        }

        [HttpPost]
        public async Task<BookDto> CreateAsync(BookEditDto input)
        {
            return await _bookAppService.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<BookDto> UpdateAsync(Guid id, BookEditDto input)
        {
            return await _bookAppService.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _bookAppService.DeleteAsync(id);
        }
    }
}