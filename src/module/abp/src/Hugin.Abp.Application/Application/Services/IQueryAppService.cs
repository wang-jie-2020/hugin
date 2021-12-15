﻿using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace LG.NetCore.Application.Services
{
    public interface IQueryAppService<TEntity, TGetOutputDto, in TKey, in TGetListInput>
        : IQueryAppService<TEntity, TGetOutputDto, TGetOutputDto, TKey, TGetListInput>
    {
    }


    public interface IQueryAppService<TEntity, TGetOutputDto, TGetListOutputDto, in TKey, in TGetListInput>
    {
        IQueryable<TEntity> DefaultQuery { get; }

        Task<TGetOutputDto> GetAsync(TKey id);

        Task<PagedResultDto<TGetListOutputDto>> GetListAsync(TGetListInput input);
    }
}



