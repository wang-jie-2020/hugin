using System;
using System.Threading.Tasks;
using LG.NetCore.Sample.BookStore.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LG.NetCore.Sample.BookStore
{
    public interface IAuthorAppService : IApplicationService
    {
        Task<AuthorDto> GetAsync(Guid id);

        Task<PagedResultDto<AuthorDto>> GetListAsync(AuthorQueryInput input);

        Task<AuthorDto> CreateAsync(AuthorEditDto input);

        Task UpdateAsync(Guid id, AuthorEditDto input);

        Task DeleteAsync(Guid id);
    }
}
